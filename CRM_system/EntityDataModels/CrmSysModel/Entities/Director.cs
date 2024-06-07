using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_system.Models.EntityDataModels.CrmSysModel.Entities
{
    [Table("TBL_Directors", Schema = "dbo")]
    public class Director
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short Id { set; get; }

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

        public short CompanyId { set; get; }

        public short DirectorAcctLogPwdId { set; get; }

        [ForeignKey(nameof(CompanyId))]
        public virtual Company Company { set; get; }

        [ForeignKey(nameof(DirectorAcctLogPwdId))]
        public virtual DirectorAcctLogPwd DirectorAcctLogPwd { set; get; }

        public Director()
        { }

        public Director(in string inSurname, in string inName, in string inPhone, in string inEmail,
            in short inCompanyId, in short inDirectorAcctLogPwdId) : this(0, inSurname, inName, inPhone, inEmail, inCompanyId, inDirectorAcctLogPwdId)
        { }

        public Director(in short inId, in string inSurname, in string inName, in string inPhone, in string inEmail, 
            in short inCompanyId, in short inDirectorAcctLogPwdId)
        {
            Id = inId;
            Surname = inSurname;
            Name = inName;
            Phone = inPhone;
            Email = inEmail;
            CompanyId = inCompanyId;
            DirectorAcctLogPwdId = inDirectorAcctLogPwdId;
        }
    }
}
