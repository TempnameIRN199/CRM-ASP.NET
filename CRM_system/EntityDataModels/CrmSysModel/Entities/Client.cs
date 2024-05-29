using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_system.Models.EntityDataModels.CrmSysModel.Entities
{
    [Table("TBL_Clients", Schema = "dbo")]
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { set; get; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Surname { set; get; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Name { set; get; }

        [StringLength(50, MinimumLength = 1)]
        public string Patronymic { set; get; }

        [Required]
        [Phone]
        public string Phone { set; get; }

        [Required]
        [EmailAddress]
        public string Email { set; get; }

        public long DealId { set; get; }

        [ForeignKey(nameof(DealId))]
        public virtual Deal Deal { set; get; }

        public virtual ICollection<ClientNotation> ClientNotations { set; get; }

        public Client()
        { }

        public Client(in string inSurname, in string inName, in string inPatronymic, in string inPhone,
            in string inEmail, in long inDealId) : this(0L, inSurname, inName, inPatronymic, inPhone, inEmail, inDealId)
        { }

        public Client(in long inId, in string inSurname, in string inName, in string inPatronymic, in string inPhone,
            in string inEmail, in long inDealId)
        {
            Id = inId;
            Surname = inSurname;
            Name = inName;
            Patronymic = inPatronymic;
            Phone = inPhone;
            Email = inEmail;
            DealId = inDealId;
        }
    }
}
