using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Kupchenko
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string County { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }
        public bool IsBoy { get; set; }
        public int YearsOld { get; set; } 
        public int BirthdayDate { get; set; }
        public int RegisterDate { get; set; }
        public int Adress { get; set; }
        public int Street { get; set; }

    }
}
