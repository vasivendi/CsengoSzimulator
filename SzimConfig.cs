using System.Collections.Generic;
using System.Xml.Serialization;

namespace Csengoszimulator_Lambda
{
    [XmlRoot]
    public class SzimConfig
    {
        public SzimConfig()
        {
            Csengetesek = new List<Csengetes>();
            Munkanap = new bool[] { true, true, true, true, true, false, false };
            Beallitas = Settings.Default;
        }
        [XmlElement]
        public List<Csengetes> Csengetesek;
        [XmlElement]
        public bool[] Munkanap; //fix méret 7
        [XmlElement]
        public Settings Beallitas;
    }
}
