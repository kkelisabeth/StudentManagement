using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Program0
{
    internal class StudentDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClassSt { get; set; }

        Date dateofBirth;
        string adress, postCOde;
        string city;

        public StudentDetails(string fName, string lName, Date dob, string a, string postC, string cl, string c)
        {
            FirstName = fName;
            LastName = lName;
            dateofBirth = dob;
            adress = a;
            postCOde = postC;
            ClassSt = cl;
            city = c; 
        }
    }
}
