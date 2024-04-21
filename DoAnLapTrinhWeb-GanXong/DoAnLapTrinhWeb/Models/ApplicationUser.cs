﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;

namespace DoAnLapTrinhWeb.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public string? Age { get; set; }
    }
}
