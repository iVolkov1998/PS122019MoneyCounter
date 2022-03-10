using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Glyackin
{
    public class TablerUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public bool Sex { get; set; }
        public string  Old { get; set; }
        public long PhoneNumber { get; set; }
        public string Nation { get; set; }
        public int Patronymic { get; set; }
    }
}
