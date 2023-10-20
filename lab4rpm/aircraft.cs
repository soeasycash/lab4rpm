using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4rpm
{
    class AircraftTypeComparer : IComparer<AEROFLOT>
    {
        public int Compare(AEROFLOT x, AEROFLOT y)
        {
            return x.AircraftType.CompareTo(y.AircraftType);
        }
    }
}
