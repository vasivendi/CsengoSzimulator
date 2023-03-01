using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Configuration;

namespace Csengoszimulator_Lambda
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent(); /*automata generált kód, a form vonzata, ez renderel*/
            outputLog = new List<string>();
            beirtAdat = new Csengetes() { CsengetesiIdo = new Idopont() { Ora = 0, Perc = 0 }, CsengetesTipus = JelzesTipus.Ki };
            sim = new Csengoszimulator();
            sim.CoreNotification += EmulatedConsole_Update;
            sim.ConfigManager.ConfigChange += OnConfigChange;
            sim.Started += SzimCoreStart;
            sim.Stopped += SzimCoreStop;

            logOutputScreen.Height = 376;
            Application.DoEvents();
        }
        private Csengoszimulator sim;
        private List<string> outputLog;

        private Csengetes beirtAdat;
        private int logLength = 0;
        
        //forms event
        private void MainForm_Load(object sender, EventArgs e)
        {
            sim.ConfigManager.LoadConfig();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sim.ConfigManager.SaveConfig();
            //a program bezáráskor még utolsó feladatként kiírja a csengetési rendet a módosítások biztos mentésére a biztonság kedvéért
        }
        //core event, todo fájlba logolás
        private void EmulatedConsole_Update(string message)
        {
            this.Invoke(new Action<string>(
                (m) =>
                {
                    outputLog.Add(DateTime.Now.ToShortTimeString() + ": " + m);
                    logLength++;
                    if (20 < logLength)
                    {
                        outputLog.RemoveAt(0);
                    }
                    logOutputScreen.Lines = outputLog.ToArray();
                    //insert fájlba írás
                }
                ),message);
        }
        private void OnConfigChange()
        {
            this.Invoke(new Action(
                () =>
                {
                    listboxCsengetések.Items.Clear();
                    List<Csengetes> cstemp = sim.ConfigManager.StoredConfig.Csengetesek;
                    for (int i = 0; i < cstemp.Count; i++)
                    {
                        listboxCsengetések.Items.Add(cstemp[i].ToString());
                    }
                    bool[] mnaptemp = sim.ConfigManager.StoredConfig.Munkanap;
                    for (int i = 0; i < 7; i++)
                    {
                        checkedListBMunkanapok.SetItemChecked(i, mnaptemp[i]);
                    }
                }));
        }
        private void SzimCoreStart()
        {
            this.Invoke(new Action(
                () =>
                {
                    groupBeállítások.Visible = false;
                    gombStart.Enabled = false;
                    gombStop.Enabled = true;
                    logOutputScreen.Visible = true;
                }));
        }
        private void SzimCoreStop()
        {
            this.Invoke(new Action(
                () =>
                {
                    groupBeállítások.Visible = true;
                    gombStart.Enabled = true;
                    gombStop.Enabled = false;
                    logOutputScreen.Visible = false;
                }));
        }

        //gombok
        private void gomb_IDP_ÚJ_Click(object sender, EventArgs e)
        {
            if (!beirtAdat.CsengetesiIdo.Valid)
            {
                MessageBox.Show("A beírt idő érvénytelen", "Beállításhiba");
            }
            else
            {
                sim.ConfigManager.StoredConfig.Csengetesek.Add(beirtAdat);
                sim.ConfigManager.SaveConfig();
            }
        }
        private void gomb_IDP_OVRW_Click(object sender, EventArgs e)
        {
            if (!(beirtAdat.CsengetesiIdo.Valid && listboxCsengetések.SelectedIndex != -1))
            {
                MessageBox.Show("A beírt idő vagy a kiválasztott elem érvénytelen", "Beállításhiba");
            }
            else
            {
                sim.ConfigManager.StoredConfig.Csengetesek[listboxCsengetések.SelectedIndex] = beirtAdat;
                sim.ConfigManager.SaveConfig();
            }
        }
        private void gomb_IDP_DEL_Click(object sender, EventArgs e)
        {
            if (listboxCsengetések.SelectedIndex == -1)
            {
                MessageBox.Show("A kiválasztott elem érvénytelen", "Beállításhiba");
            }
            else
            {
                sim.ConfigManager.StoredConfig.Csengetesek.RemoveAt(listboxCsengetések.SelectedIndex);
                sim.ConfigManager.SaveConfig();
            }
        }
        private void MunkanapokMentes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                sim.ConfigManager.StoredConfig.Munkanap[i] = checkedListBMunkanapok.GetItemChecked(i);
            }
            sim.ConfigManager.SaveConfig();
        }

        //forms módosulás event
        private void ValueDoboz_TextChanged(object sender, EventArgs e)
        {
            bool validtime = true;
            Idopont temp = new Idopont();
            {
                int o, p;
                if (!int.TryParse(textBoxORA.Text, out o))
                {
                    textBoxORA.Text = "";
                    validtime = false;
                }
                if (!int.TryParse(textBoxPERC.Text, out p))
                {
                    textBoxPERC.Text = "";
                    validtime = false;
                }
                if (!validtime)
                {
                    return;
                }
                temp.Ora = o;
                temp.Perc = p;
            }
            if (validtime)
            {
                beirtAdat.CsengetesiIdo = temp;
            }
            if (radioButton_BECS.Checked)
            {
                beirtAdat.CsengetesTipus = JelzesTipus.Be;
            }
            else if (radioButton_JELZ.Checked)
            {
                beirtAdat.CsengetesTipus = JelzesTipus.Jelzo;
            }
            else if (radioButton_KICS.Checked)
            {
                beirtAdat.CsengetesTipus = JelzesTipus.Ki;
            }
        }
        private void listboxCsengetések_Click(object sender, EventArgs e)
        {
            if (listboxCsengetések.SelectedIndex == -1)
            {
                return;
            }
            Csengetes c = sim.ConfigManager.StoredConfig.Csengetesek[listboxCsengetések.SelectedIndex];
            textBoxORA.Text = c.CsengetesiIdo.Ora.ToString();
            textBoxPERC.Text = c.CsengetesiIdo.Perc.ToString();
            switch (beirtAdat.CsengetesTipus)
            {
                case JelzesTipus.Ki:
                    radioButton_BECS.Checked = true;
                    break;
                case JelzesTipus.Jelzo:
                    radioButton_JELZ.Checked = true;
                    break;
                case JelzesTipus.Be:
                    radioButton_KICS.Checked = true;
                    break;
            }
            //here be code
        }

        //kapcsoló
        private void powerSwitchOn(object sender, EventArgs e)
        {
            //gombStart.Enabled = false;
            sim.Start();
            //outputLog.Clear();
            //logLength = 0;
        }
        private void powerSwitchOff(object sender, EventArgs e)
        {
            //gombStop.Enabled = false;
            sim.Stop();
        }
    }
}
