using System;
using CRM_system.EntityDataModels.CrmSysModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace CRM_system.Models.EntityDataModels.CrmSysModel
{
    public partial class CrmSysContext : DbContext
    {
        public CrmSysContext()
        {
        }

        public CrmSysContext(DbContextOptions<CrmSysContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Director> Directors { set; get; }
        public DbSet<Manager> Managers { set; get; }
        public DbSet<Client> Clients { set; get; }
        public DbSet<Company> Companies { set; get; }
        public DbSet<Deal> Deals { set; get; }
        public DbSet<ClientNotation> ClientsNotations { set; get; }
        public DbSet<DealEvent> DealsEvents { set; get; }
        public DbSet<ManagerAcctLogPwd> ManagersAcctsLogsPwds { set; get; }
        public DbSet<DirectorAcctLogPwd> DirectorsAcctsLogsPwds { set; get; }

    }
}
