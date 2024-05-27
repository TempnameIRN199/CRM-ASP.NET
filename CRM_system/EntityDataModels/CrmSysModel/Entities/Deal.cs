using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_system.Models.EntityDataModels.CrmSysModel.Entities
{
    [Table("TBL_Deals", Schema = "dbo")]
    public class Deal
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
        public double Amount { set; get; }

        [Required]
        public long ClientId { set; get; }

        [Required]
        public int ManagerId { set; get; }

        [Required]
        public byte DealStatusId { set; get; }

        [ForeignKey(nameof(ClientId))]
        public virtual Client Client { set; get; }

        [ForeignKey(nameof(ManagerId))]
        public virtual Manager Manager { set; get; }

        [ForeignKey(nameof(DealStatusId))]
        public virtual DealStatus DealStatus { set; get; }

        public virtual ICollection<DealEvent> DealEvents { set; get; }

        public Deal(in string inDescription, in DateTime inDate, in double inAmount, in long inClientId,
            in int inManagerId, in byte inDealStatusId) : this(0L, inDescription, inDate, inAmount, inClientId, inManagerId, inDealStatusId)
        { }

        public Deal(in long inId, in string inDescription, in DateTime inDate, in double inAmount,
            in long inClientId, in int inManagerId, in byte inDealStatusId)
        {
            Id = inId;
            Description = inDescription;
            Date = inDate;
            Amount = inAmount;
            ClientId = inClientId;
            ManagerId = inManagerId;
            DealStatusId = inDealStatusId;
        }
    }
}
