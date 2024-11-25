﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModel.User
{
    public class UserCreateVM
    {

        public string Email { get; set; } = null!;

        public string Name { get; set; } = null!;

        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        public bool? IsVerified { get; set; }

        public string? Status { get; set; } = "active";

        public string? PhoneNumber { get; set; }

    }
}
