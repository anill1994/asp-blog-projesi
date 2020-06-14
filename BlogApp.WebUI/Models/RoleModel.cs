﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BlogApp.WebUI.Models
{
        public class RoleDetails
        {
            public IdentityRole Role { get; set; }
            public IEnumerable<ApplicationUser> Members { get; set; }
            public IEnumerable<ApplicationUser> NonMembers { get; set; }
        }
        public class RoleEditModel
        {
            public string RoleId { get; set; }
            public string RoleName { get; set; }

            public string[] IdsToAdd { get; set; }
            public string[] IdsToDelete { get; set; }
        }
    }

