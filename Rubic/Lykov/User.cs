﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Lykov
{
    public class User
    {
        public int Id { get; set; }

        public string Nickname { get; set; }

        public bool IsBoy { get; set; }

        public DateTimeOffset Birthday  { get; set; }
        public int PhoneNumberPrefix { get; set; }
        public int PhoneNuber { get; set; }

        public string Email { get; set; }

        public string AvatarUrl { get; set; }

        public string Token { get; set; }

        public Profile Profile { get; set; }
    }
}