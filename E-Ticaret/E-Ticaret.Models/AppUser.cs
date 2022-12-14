using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace E_Ticaret.Models
{
    public class AppUser:IdentityUser
    {
        [Required]
        public string FullName { get; set; }
        public string Adress { get; set; }
        public string PostaCode { get; set; }
        public string CellPhone { get; set; }

        [NotMapped]
        public string Role { get; set; }

    }
}
