using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_system.EntityDataModels.CrmSysModel.Entities
{
    [Table("TBL_ManagersAcctsLogsPwds", Schema = "dbo")]
    public class ManagerAcctLogPwd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Login { set; get; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Password { set; get; }

        [ForeignKey(nameof(ManagerId))]
        public int ManagerId { set; get; }

        public virtual Manager Manager { set; get; }

        public ManagerAcctLogPwd()
        { }

        public ManagerAcctLogPwd(in string inLogin, in string inPassword, in int inManagerId) : this(0, inLogin, inPassword, inManagerId)
        { }

        public ManagerAcctLogPwd(in int inId, in string inLogin, in string inPassword, in int inManagerId)
        {
            Id = inId;
            Login = inLogin;
            Password = inPassword;
            ManagerId = inManagerId;
        }
    }
}
