using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Ovchinnikov
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public int PhoneNumberPrefix { get; set; }
        public long PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool isMan { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime DayOfBirth { get; set; }
    }
}
