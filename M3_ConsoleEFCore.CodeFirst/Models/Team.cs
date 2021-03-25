using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_ConsoleEFCore.CodeFirst.Models
{
    [Table("Team")]
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string Description { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Country { get; set; }


    }
}
