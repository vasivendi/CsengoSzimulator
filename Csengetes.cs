using System;

namespace Csengoszimulator_Lambda
{
    public struct Csengetes : IComparable<Csengetes>{
        public Idopont CsengetesiIdo;
        public JelzesTipus CsengetesTipus;
        public int CompareTo(Csengetes other)
        {
            return this.CsengetesiIdo.CompareTo(other.CsengetesiIdo);
        }
        public override string ToString()
        {
            return $"{this.CsengetesiIdo.Ora}:{this.CsengetesiIdo.Perc}:{this.CsengetesTipus.ToString()[0]}";
        }
    }
}
