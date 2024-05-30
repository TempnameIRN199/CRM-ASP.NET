using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_system.Models.EntityDataModels.CrmSysModel.Entities
{
    [Table("TBL_ClientsNotations", Schema = "dbo")]
    public class ClientNotation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { set; get; }

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string Text { set; get; }

        [Required]
        public DateTime Date { set; get; }

        [Required]
        public long ClientId { set; get; }

        [ForeignKey(nameof(ClientId))]
        public virtual Client Client { set; get; }

        public ClientNotation()
        { }

        public ClientNotation(in string inText, in DateTime inDate, in long inClientId) : this(0L, inText, inDate, inClientId)
        { }

        public ClientNotation(in long inId, in string inText, in DateTime inDate, in long inClientId)
        {
            Id = inId;
            Text = inText;
            Date = inDate;
            ClientId = inClientId;
        }
    }
}
