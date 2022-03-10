using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Kedrov
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string patronymic { get; set; }
        public DateTime RegTime { get; set; }
        public DateTime BirthTime { get; set; }
        public bool IsBoy { get; set; }
        public string Mail  { get; set; }
        public string Status { get; set; }
        public string Publications { get; set; }

    }
}
