using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_system.Models.EntityDataModels.CrmSysModel.Entities
{
    [Table("TBL_DealStatuses", Schema = "dbo")]
    public class DealStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { set; get; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { set; get; }

        public virtual ICollection<Deal> Deals { set; get; }

        public DealStatus(in string inName) : this(0, inName)
        { }

        public DealStatus(in byte inId, in string inName)
        {
            Id = inId;
            Name = inName;
        }
    }
}
