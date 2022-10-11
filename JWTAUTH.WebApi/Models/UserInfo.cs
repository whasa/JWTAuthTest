﻿using System;
using System.Collections.Generic;

namespace JWTAUTH.WebApi.Models
{
    public partial class UserInfo
    {
        public int UserId { get; set; }
        public string DisplayName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }
}
