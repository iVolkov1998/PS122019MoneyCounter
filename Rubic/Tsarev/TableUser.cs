using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Tsarev
{
    public class TableUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public bool Gender { get; set; }
        public string Old { get; set; }
        public string Nationality { get; set; }
        public long PhoneNumber { get; set; }
        public string Password { get; set; }

    }
}
