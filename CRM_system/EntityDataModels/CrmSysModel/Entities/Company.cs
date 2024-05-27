using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_system.Models.EntityDataModels.CrmSysModel.Entities
{
    [Table("TBL_Companies", Schema = "dbo")]
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Id { set; get; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { set; get; }

        [Required]
        public DateTime DateOfEstab { set; get; }

        [Required]
        public short DirectorId { set; get; }

        [ForeignKey(nameof(DirectorId))]
        public virtual Director Director { set; get; }

        public virtual ICollection<Manager> Managers { set; get; }

        public Company(in string inName, in DateTime inDateOfEstab, in short inDirectorId) :
            this(0, inName, inDateOfEstab, inDirectorId)
        { }

        public Company(in short inId, in string inName, in DateTime inDateOfEstab, in short inDirectorId)
        {
            Id = inId;
            Name = inName;
            DateOfEstab = inDateOfEstab;
            DirectorId = inDirectorId;
        }
    }
}
