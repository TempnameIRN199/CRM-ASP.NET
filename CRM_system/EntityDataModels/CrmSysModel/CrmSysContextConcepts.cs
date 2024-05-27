using System;
using System.Data.Entity;

namespace CRM_system.Models.EntityDataModels.CrmSysModel
{
    using Entities;

    public partial class CrmSysContext : DbContext
    {
        public DbSet<Director> Directors { set; get; }
        public DbSet<Manager> Managers { set; get; }
        public DbSet<Client> Clients { set; get; }
        public DbSet<Company> Companies { set; get; }
        public DbSet<Deal> Deals { set; get; }
        public DbSet<ClientNotation> ClientsNotations { set; get; }
        public DbSet<DealEvent> DealsEvents { set; get; }
        public DbSet<ManagerAcctLogPwd> ManagersAcctsLogsPwds { set; get; }
        public DbSet<DirectorAcctLogPwd> DirectorsAcctsLogsPwds { set; get; }

        public CrmSysContext()
        {

        }
    }
}
