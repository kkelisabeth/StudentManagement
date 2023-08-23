using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Program0
{
    internal class ClassStanding : ObservableCollection<string>
    {
        public ClassStanding()
        {
            Add("Freshman");
            Add("Sophomore");
            Add("Junior");
            Add("Senior");
        }
    }
}
