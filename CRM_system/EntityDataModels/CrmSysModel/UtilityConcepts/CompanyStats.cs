using System;

namespace CRM_system.Models.EntityDataModels.CrmSysModel.UtilityConcepts
{
    public sealed class CompanyStats
    {
        public short CompanyId { set; get; }
        public short FailedDeals { set; get; }
        public short ActiveDeals { set; get; }
        public short SuccessfulDeals { set; get; }
        public double Income { set; get; }
    }
}
