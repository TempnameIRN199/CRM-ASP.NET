using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_system.Models.EntityDataModels.CrmSysModel.Entities
{
    [Table("TBL_Managers", Schema = "dbo")]
    public class Manager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

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

        [Required]
        public short CompanyId { set; get; }

        public int ManagerAcctLogPwdId { set; get; }

        [ForeignKey(nameof(CompanyId))]
        public virtual Company Company { set; get; }

        [ForeignKey(nameof(ManagerAcctLogPwdId))]
        public virtual ManagerAcctLogPwd ManagerAcctLogPwd { set; get; }

        public Manager()
        { }

        public Manager(in string inSurname, in string inName, in string inPhone, in string inEmail,
            in short inCompanyId, in int inManagerAcctLogPwdId) : this(0, inSurname, inName, inPhone, inEmail, inCompanyId, inManagerAcctLogPwdId)
        { }

        public Manager(in int inId, in string inSurname, in string inName, in string inPhone, in string inEmail, in short inCompanyId, in int inManagerAcctLogPwdId)
        {
            Id = inId;
            Surname = inSurname;
            Name = inName;
            Phone = inPhone;
            Email = inEmail;
            CompanyId = inCompanyId;
            ManagerAcctLogPwdId = inManagerAcctLogPwdId;
        }
    }
}
