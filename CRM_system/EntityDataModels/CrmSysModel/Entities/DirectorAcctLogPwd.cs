using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_system.Models.EntityDataModels.CrmSysModel.Entities
{
    [Table("TBL_DirectorsAcctsLogsPwds", Schema = "dbo")]
    public class DirectorAcctLogPwd
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

        [Required]
        public int DirectorId { set; get; }

        [ForeignKey(nameof(DirectorId))]
        public virtual Director Director { set; get; }

        public DirectorAcctLogPwd(in string inLogin, in string inPassword, in int inDirectorId) : this(0, inLogin, inPassword, inDirectorId)
        { }

        public DirectorAcctLogPwd(in int inId, in string inLogin, in string inPassword, in int inDirectorId)
        {
            Id = inId;
            Login = inLogin;
            Password = inPassword;
            DirectorId = inDirectorId;
        }
    }
}
