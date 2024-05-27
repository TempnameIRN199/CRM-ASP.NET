using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_system.Models.EntityDataModels.CrmSysModel.Entities
{
    [Table("TBL_DealsEvents", Schema = "dbo")]
    public class DealEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { set; get; }

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Description { set; get; }

        [Required]
        public DateTime Date { set; get; }

        [Required]
        public long DealId { set; get; }

        [ForeignKey(nameof(DealId))]
        public virtual Deal Deal { set; get; }

        public DealEvent(in string inDescription, in DateTime inDate, in long inDealId) : this(0L, inDescription, inDate, inDealId)
        { }

        public DealEvent(in long inId, in string inDescription, in DateTime inDate, in long inDealId)
        {
            Id = inId;
            Description = inDescription;
            Date = inDate;
            DealId = inDealId;
        }
    }
}
