using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace Csengoszimulator_Lambda
{
    public class Csengoszimulator
    {
        public event Action<string> CoreNotification;
        public event Action Started, Stopped;

        private Task CoreProcess;
        private CancellationTokenSource TokenSource;
        public readonly SzimConfigManager ConfigManager;

        public Csengoszimulator()
        {
            ConfigManager = new SzimConfigManager();
            TokenSource = new CancellationTokenSource();
            CoreProcess = new Task(() => CoreMethod(TokenSource.Token), TokenSource.Token);
        }

        private int DayOfWeek()
        {
            int d = (int)DateTime.Now.DayOfWeek - 1;
            if (d == -1)
            {
                d = 6;
            }
            return d;
        }

        private void CoreMethod(CancellationToken CancelToken)
        {
            Started();
            //lejátszók azonos sorrendben mint az enum
            SoundPlayer[] hangok = new SoundPlayer[3] {
                new SoundPlayer(ConfigManager.StoredConfig.Beallitas.zenemappa+ConfigManager.StoredConfig.Beallitas.kicshang),
                new SoundPlayer(ConfigManager.StoredConfig.Beallitas.zenemappa+ConfigManager.StoredConfig.Beallitas.jelzhang),
                new SoundPlayer(ConfigManager.StoredConfig.Beallitas.zenemappa+ConfigManager.StoredConfig.Beallitas.becshang)
            };
            //a biztonságos keresztszálas hozzáférés miatt másolatból megy a mag
            List<Csengetes> csengetesek = ConfigManager.StoredConfig.Csengetesek;
            if (csengetesek.Count <= 0)
            {
                Stopped();
                return;
            }
            /*A CSENGETŐCORE*/
            int p = -1;
            Idopont rtc = Idopont.Now();
            CoreNotification("Háttérfolyamat indítása, következő csengetés megkeresése");
            {
                for (int i = 0; i < csengetesek.Count; i++)
                {
                    Csengetes c = csengetesek[i];
                    //CoreNotification(c.ToString());
                    if (rtc.CompareTo(c.CsengetesiIdo) < 0)
                    {
                        //CoreNotification("találat");
                        p = i;
                        break;
                    }
                }
            }
            //p is set by now
            {
                bool workday = false;
                int sleeplength = 5000;
                if (p == -1)
                {
                    sleeplength = 60000;
                }
                while (!CancelToken.IsCancellationRequested)
                {
                    workday = ConfigManager.StoredConfig.Munkanap[DayOfWeek()];
                    if (p == -1)
                    {
                        CoreNotification("Alvás folyamatban");
                        if (workday && Idopont.Now().CompareTo(csengetesek[0].CsengetesiIdo) < 1)
                        {
                            CoreNotification("Ébresztés");
                            p = 0;
                            sleeplength = 5000;
                        }
                    }
                    else
                    {
                        if ((!workday) | p >= csengetesek.Count)
                        {
                            CoreNotification("Altatás");
                            p = -1;
                            sleeplength = 60000;
                            continue;
                        }

                        if (Idopont.Now().CompareTo(ConfigManager.StoredConfig.Csengetesek[p].CsengetesiIdo) > -1)
                        {
                            Csengetes cs = ConfigManager.StoredConfig.Csengetesek[p];
                            CoreNotification("Hanglejátszás: " + cs.CsengetesTipus.ToString());
                            hangok[(int)cs.CsengetesTipus].PlaySync();
                            p++;
                        }
                        //sleep short, check real time and if match play sound and move p

                        //if p by here is eq to count, then set to -1, sleep
                    }
                    Thread.Sleep(sleeplength);
                }
            }
            
            
        //Exit:
            CoreNotification("Leállítás...");
            Thread.Sleep(1000);
            //CSENGETŐCORE vége
            Stopped();
        }

        public void Start()
        {
            if (CoreProcess.Status != TaskStatus.Created && !CoreProcess.IsCompleted)
            {
                CoreNotification("Előző magfolyamat még nem állt le");
                return;
            }
            TokenSource = new CancellationTokenSource();
            TokenSource.Token.Register(() => { CoreNotification("Leállítás jelezve, várakozás"); });
            CoreProcess = new Task(() => CoreMethod(TokenSource.Token), TokenSource.Token);
            CoreProcess.Start();
        }
        public void Stop()
        {
            if (CoreProcess.IsCompleted)
            {
                CoreNotification("Előző magfolyamat már leállt");
                return;
            }
            TokenSource.Cancel();
            CoreProcess = new Task(() => CoreMethod(TokenSource.Token), TokenSource.Token);
        }
    }
}
