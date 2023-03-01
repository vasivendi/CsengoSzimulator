using System;
using System.IO;
using System.Xml.Serialization;

namespace Csengoszimulator_Lambda
{
    public class SzimConfigManager
    {
        public SzimConfigManager()
        {
            StoredConfig = new SzimConfig();
            SzimTransf = new XmlSerializer(typeof(SzimConfig));
        }
        public SzimConfig StoredConfig;
        public event Action ConfigChange;
        private XmlSerializer SzimTransf;
        public void LoadConfig()
        {
            FileStream Configstream = File.Open(AppContext.BaseDirectory + "config.xml", FileMode.OpenOrCreate);
            if (Configstream.Length == 0)
            {
                StoredConfig = new SzimConfig();
                Configstream.Close();
                ConfigChange();
                return;
            }

            StoredConfig = (SzimConfig)SzimTransf.Deserialize(Configstream);

            Configstream.Close();
            ConfigChange();
        }
        public void SaveConfig()
        {
            StoredConfig.Csengetesek.Sort();

            FileStream Configstream = File.Open(AppContext.BaseDirectory + "config.xml", FileMode.Create);
            SzimTransf.Serialize(Configstream, StoredConfig);

            Configstream.Close();
            ConfigChange();
        }
    }
}
