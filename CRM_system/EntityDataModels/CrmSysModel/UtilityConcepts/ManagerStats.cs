using System;

namespace CRM_system.EntityDataModels.CrmSysModel.UtilityConcepts
{
    public sealed class ManagerStats
    {
        public int ManagerId { set; get; }
        public byte FailedDeals { set; get; }
        public byte ActiveDeals { set; get; }
        public byte SuccessfulDeals { set; get; }
        public double Income { set; get; }
    }
}
