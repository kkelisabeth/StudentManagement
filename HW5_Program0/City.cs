using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Program0
{
    internal class City : ObservableCollection<string>
    {
        public City()
        {
            Add("Limassol");
            Add("Paphos");
            Add("Nicosia");
            Add("Larnace");
        }
    }
}
