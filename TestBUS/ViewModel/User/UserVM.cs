﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModel.User
{
    public class UserVM
    {
        public int UserId { get; set; }

        public string Email { get; set; } = null!;

        public string Name { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }

        public bool? IsVerified { get; set; }

        public DateTime? LastLogin { get; set; }

        public string? Status { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime? EmailVerifiedAt { get; set; }

    }
}
