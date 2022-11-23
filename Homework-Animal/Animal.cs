using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Animal
{
    internal class Animal
    {
        private string _gender;
        private int _birthyear;

        public string Gender
        {
            get => Gender;
            set { Gender = value; }
        }

        public int BirthYear
        {
            get => BirthYear;
            set { BirthYear = value; }
        }
    }
}
