﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace concertticket_webapp_appserver.DTOs
{
    public class UserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set;}
        public string Token { get; set; }
        public string Role { get; set; }
    }
}