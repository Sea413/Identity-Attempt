using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StackOverflow.ViewModels
{
    public class RoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string Role { get; set; }
    }
}
