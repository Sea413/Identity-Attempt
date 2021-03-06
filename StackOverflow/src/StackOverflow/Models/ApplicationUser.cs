﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using StackOverflow.Models;

namespace StackOverflow.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<ApplicationRole> IdentityRoles { get; set; }
    }
}
