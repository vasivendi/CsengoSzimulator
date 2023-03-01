using System;
using System.Xml.Serialization;

namespace Csengoszimulator_Lambda
{
    public struct Settings
    {
        static public Settings Default = new Settings()
        {
            zenemappa = AppContext.BaseDirectory + @"zenek\",
            kicshang = "kicsengo.wav",
            becshang = "becsengo.wav",
            jelzhang = "jelcsengo.wav"
        };
        [XmlElement]
        public string zenemappa, kicshang, becshang, jelzhang;
    }
}
