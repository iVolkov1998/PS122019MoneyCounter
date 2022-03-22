﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rubic.Kedrov
{
    public class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public bool IsBoy { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public int PhoneNumberPrefix { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string AvatarUrl { get; set; }
        public string Token { get; set; }
        public Profile Profile { get; set; }
        public List<Friends> FirstFriends { get; set; }
        public List<Friends> SecondFriends { get; set; }
    }
}