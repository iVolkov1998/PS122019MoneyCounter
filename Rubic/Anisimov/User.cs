using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Anisimov
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public int PhoneNumberPrefix { get; set; }
        public long PhoneNumber { get; set; }
        public bool IsBoy { get; set; }
        public DateTime BirthdayDate { get; set; }
        public DateTime RegestrationDate { get; set; }
        public int Adress { get; set; }
        public int YearsOld { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
