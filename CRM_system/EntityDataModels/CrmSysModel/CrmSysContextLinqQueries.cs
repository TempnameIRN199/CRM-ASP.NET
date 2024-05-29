using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CRM_system.Models.EntityDataModels.CrmSysModel
{
    using Entities;
    using UtilityConcepts;

    public partial class CrmSysContext : DbContext
    {
        public static class LinqQueries
        {
            public static class AddEntityQueries
            {
                public static void AddClientAndDeal(in CrmSysContext inCrmSysContext, in Client inClient, in Deal inDeal)
                {
                    AddClient(inCrmSysContext, inClient);
                    AddDeal(inCrmSysContext, inDeal);

                    inClient.DealId = inDeal.Id;
                    inDeal.ClientId = inClient.Id;

                    inCrmSysContext.SaveChanges();
                }

                public static void AddManagerAcct(in CrmSysContext inCrmSysContext, in Manager inManager,
                    in ManagerAcctLogPwd inManagerAcctLogPwd)
                {
                    AddManager(inCrmSysContext, inManager);
                    AddManagerAcctLogPwd(inCrmSysContext, inManagerAcctLogPwd);

                    inManager.ManagerAcctLogPwdId = inManagerAcctLogPwd.Id;
                    inManagerAcctLogPwd.ManagerId = inManager.Id;

                    inCrmSysContext.SaveChanges();
                }

                public static void AddCompanyDirectorAcct(in CrmSysContext inCrmSysContext, in Company inCompany,
                    in Director inDirector, in DirectorAcctLogPwd inDirectorAcctLogPwd)
                {
                    AddCompany(inCrmSysContext, inCompany);
                    AddDirector(inCrmSysContext, inDirector);
                    AddDirectorAcctLogPwd(inCrmSysContext, inDirectorAcctLogPwd);

                    inCompany.DirectorId = inDirector.Id;
                    inDirector.CompanyId = inCompany.Id;

                    inDirectorAcctLogPwd.DirectorId = inDirector.Id;
                    inDirector.DirectorAcctLogPwdId = inDirectorAcctLogPwd.Id;

                    inCrmSysContext.SaveChanges();
                }

                public static void AddDealEvent(in CrmSysContext inCrmSysContext, in DealEvent inDealEvent)
                {
                    inCrmSysContext.DealsEvents.Add(inDealEvent);

                    inCrmSysContext.SaveChanges();
                }

                public static void AddClientNotation(in CrmSysContext inCrmSysContext, in ClientNotation inClientNotation)
                {
                    inCrmSysContext.ClientsNotations.Add(inClientNotation);

                    inCrmSysContext.SaveChanges();
                }

                private static void AddDirector(in CrmSysContext inCrmSysContext, in Director inDirector)
                {
                    inCrmSysContext.Directors.Add(inDirector);

                    inCrmSysContext.SaveChanges();
                }

                private static void AddManager(in CrmSysContext inCrmSysContext, in Manager inManager)
                {
                    inCrmSysContext.Managers.Add(inManager);

                    inCrmSysContext.SaveChanges();
                }

                private static void AddClient(in CrmSysContext inCrmSysContext, in Client inClient)
                {
                    inCrmSysContext.Clients.Add(inClient);

                    inCrmSysContext.SaveChanges();
                }

                private static void AddCompany(in CrmSysContext inCrmSysContext, in Company inCompany)
                {
                    inCrmSysContext.Companies.Add(inCompany);

                    inCrmSysContext.SaveChanges();
                }

                private static void AddDeal(in CrmSysContext inCrmSysContext, in Deal inDeal)
                {
                    inCrmSysContext.Deals.Add(inDeal);

                    inCrmSysContext.SaveChanges();
                }

                private static void AddDirectorAcctLogPwd(in CrmSysContext inCrmSysContext, in DirectorAcctLogPwd inDirectorAcctLogPwd)
                {
                    inCrmSysContext.DirectorsAcctsLogsPwds.Add(inDirectorAcctLogPwd);

                    inCrmSysContext.SaveChanges();
                }

                private static void AddManagerAcctLogPwd(in CrmSysContext inCrmSysContext, in ManagerAcctLogPwd inManagerAcctLogPwd)
                {
                    inCrmSysContext.ManagersAcctsLogsPwds.Add(inManagerAcctLogPwd);

                    inCrmSysContext.SaveChanges();
                }
            }

            public static class AlterEntityQueries
            {
                public static void AlterDeal(in CrmSysContext inCrmSysContext, in Deal inDeal)
                {
                    inCrmSysContext.Deals.Attach(inDeal);
                    inCrmSysContext.Entry(inDeal).State = EntityState.Modified;

                    inCrmSysContext.SaveChanges();
                }
            }

            public static class DeleteEntityQueries
            {
                public static void DeleteCompany(in CrmSysContext inCrmSysContext, in Company inCompany)
                {
                    inCrmSysContext.Companies.Remove(inCompany);

                    inCrmSysContext.SaveChanges();
                }

                public static void DeleteManager(in CrmSysContext inCrmSysContext, in Manager inManager)
                {
                    inCrmSysContext.Managers.Remove(inManager);

                    inCrmSysContext.SaveChanges();
                }

                public static void DeleteDeal(in CrmSysContext inCrmSysContext, in Deal inDeal)
                {
                    inCrmSysContext.Deals.Remove(inDeal);

                    inCrmSysContext.SaveChanges();
                }

                public static void DeleteDealEvent(in CrmSysContext inCrmSysContext, in DealEvent inDealEvent)
                {
                    inCrmSysContext.DealsEvents.Remove(inDealEvent);

                    inCrmSysContext.SaveChanges();
                }

                public static void DeleteClientNotation(in CrmSysContext inCrmSysContext, in ClientNotation inClientNotation)
                {
                    inCrmSysContext.ClientsNotations.Remove(inClientNotation);

                    inCrmSysContext.SaveChanges();
                }
            }

            public static class GetInformationQueries
            {
                public static CompanyStats GetCompanyStatsInCurrMonth(in CrmSysContext inCrmSysContext, short inCompanyId)
                {
                    ICollection<ManagerStats> tmpCollOfManagerStats = new List<ManagerStats>();
                    CompanyStats tmpCompanyStats = new CompanyStats();

                    foreach (var tmpManager in inCrmSysContext.Managers.Where((inManager) => inManager.CompanyId == inCompanyId))
                        tmpCollOfManagerStats.Add(GetManagerStatsInCurrMonth(inCrmSysContext, tmpManager.Id));

                    tmpCompanyStats.FailedDeals = (short)tmpCollOfManagerStats.Sum((inManagerStats) => inManagerStats.FailedDeals);
                    tmpCompanyStats.SuccessfulDeals = (short)tmpCollOfManagerStats.Sum((inManagerStats) => inManagerStats.SuccessfulDeals);
                    tmpCompanyStats.ActiveDeals = (short)tmpCollOfManagerStats.Sum((inManagerStats) => inManagerStats.ActiveDeals);
                    tmpCompanyStats.Income = (short)tmpCollOfManagerStats.Sum((inManagerStats) => inManagerStats.Income);

                    return tmpCompanyStats;
                }

                public static ManagerStats GetManagerStatsInCurrMonth(in CrmSysContext inCrmSysContext, int inManagerId)
                {
                    ManagerStats tmpManagerStats = new ManagerStats()
                    {
                        ManagerId = inManagerId,

                        FailedDeals = (byte)inCrmSysContext.Deals.Where
                        ((inDeal) => inDeal.ManagerId == inManagerId &&
                        inDeal.Date.Month == DateTime.Now.Month &&
                        inDeal.DealStatusId == 0).Count(),

                        ActiveDeals = (byte)inCrmSysContext.Deals.Where
                        ((inDeal) => inDeal.ManagerId == inManagerId &&
                        inDeal.Date.Month == DateTime.Now.Month &&
                        inDeal.DealStatusId == 1).Count(),

                        SuccessfulDeals = (byte)inCrmSysContext.Deals.Where
                        ((inDeal) => inDeal.ManagerId == inManagerId &&
                        inDeal.Date.Month == DateTime.Now.Month &&
                        inDeal.DealStatusId == 2).Count(),

                        Income = (byte)inCrmSysContext.Deals.Where
                        ((inDeal) => inDeal.ManagerId == inManagerId &&
                        inDeal.Date.Month == DateTime.Now.Month &&
                        inDeal.DealStatusId == 2).Sum((inDeal) => inDeal.Amount)
                    };

                    return tmpManagerStats;
                }

                public static ICollection<DealEvent> GetManagerDealsEventsForToday(in CrmSysContext inCrmSysContext, int inManagerId) =>
                    inCrmSysContext.Deals.Join(inCrmSysContext.DealsEvents, inDeal => inDeal.Id, inDealEvent => inDealEvent.DealId,
                        (inDeal, inDealEvent) => new { Deal = inDeal, DealEvent = inDealEvent}).
                    Where((inFirstResult) => inFirstResult.Deal.ManagerId == inManagerId).
                    Select((inSecondResult) => inSecondResult.DealEvent).ToList();
            }
        }
    }
}
