using System;

namespace Csengoszimulator_Lambda
{
    public struct Idopont : IComparable<Idopont>
    {
        public int Ora, Perc;
        public int CompareTo(Idopont other)
        {
            int v = Ora.CompareTo(other.Ora);
            if (v == 0)
            {
                v = Perc.CompareTo(other.Perc);
            }
            return v;
        }
        /// <summary>
        /// Returns the local time converted to a <see cref="Idopont"/>
        /// </summary>
        /// <returns>The <see cref="DateTime.Now"/> time as Idopont</returns>
        static public Idopont Now()
        {
            DateTime n = DateTime.Now;
            return new Idopont() { Ora = n.Hour, Perc = n.Minute };
        }
        public bool Valid
        {
            get { return (0 <= Ora & Ora < 24 & 0 <= Perc & Perc < 60); }
        }
    }
}
