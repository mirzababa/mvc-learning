using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations.Schema;         // for DatabaseGeneratedOption (auto generate)
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirst1.Models
{
    public class Machine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters.")]
        [Index(IsUnique = true)]
        [Required] // not null
        public string Name { get; set; }


        [Required]
        //[Range (0 , 10)]
        //[Display(Name = " Must be in range 0 to 10")]
        public byte Level { get; set; } //tiny int


        [StringLength(8, ErrorMessage = "First name cannot be longer than 8 characters.")]
        public string Code { get; set; }


        [StringLength(256, ErrorMessage = "First name cannot be longer than 256 characters.")]
        //[Display(Name = " Add a description for the machine")]
        public string Descriptin { get; set; }


        public int? ParentId { get; set; }

        public virtual Machine Parent { get; set; }

        public virtual ICollection<Machine> Children { get; set; }

        public class Mapping : EntityTypeConfiguration<Machine>
        {
            public Mapping()
            {
            HasOptional(m => m.Parent).WithMany(m => m.Children);
            }
        }

    }
}