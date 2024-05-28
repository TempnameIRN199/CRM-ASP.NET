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
                public static void AddDirector(in CrmSysContext inCrmSysContext, in Director inDirector)
                {
                    inCrmSysContext.Directors.Add(inDirector);

                    inCrmSysContext.SaveChanges();
                }

                public static void AddManager(in CrmSysContext inCrmSysContext, in Manager inManager)
                {
                    inCrmSysContext.Managers.Add(inManager);

                    inCrmSysContext.SaveChanges();
                }

                public static void AddClient(in CrmSysContext inCrmSysContext, in Client inClient)
                {
                    inCrmSysContext.Clients.Add(inClient);

                    inCrmSysContext.SaveChanges();
                }

                public static void AddCompany(in CrmSysContext inCrmSysContext, in Company inCompany)
                {
                    inCrmSysContext.Companies.Add(inCompany);

                    inCrmSysContext.SaveChanges();
                }

                public static void AddDeal(in CrmSysContext inCrmSysContext, in Deal inDeal)
                {
                    inCrmSysContext.Deals.Add(inDeal);

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

                public static void AddDirectorAcctLogPwd(in CrmSysContext inCrmSysContext, in DirectorAcctLogPwd inDirectorAcctLogPwd)
                {
                    inCrmSysContext.DirectorsAcctsLogsPwds.Add(inDirectorAcctLogPwd);

                    inCrmSysContext.SaveChanges();
                }

                public static void AddManagerAcctLogPwd(in CrmSysContext inCrmSysContext, in ManagerAcctLogPwd inManagerAcctLogPwd)
                {
                    inCrmSysContext.ManagersAcctsLogsPwds.Add(inManagerAcctLogPwd);

                    inCrmSysContext.SaveChanges();
                }
            }

            public static class AlterEntityQueries
            {
                public static void AlterDirector(in CrmSysContext inCrmSysContext, in Director inDirector)
                {

                }

                public static void AlterManager(in CrmSysContext inCrmSysContext, in Manager inManager)
                {

                }

                public static void AlterClient(in CrmSysContext inCrmSysContext, in Client inClient)
                {

                }

                public static void AlterCompany(in CrmSysContext inCrmSysContext, in Company inCompany)
                {

                }

                public static void AlterDeal(in CrmSysContext inCrmSysContext, in Deal inDeal)
                {

                }

                public static void AlterDealEvent(in CrmSysContext inCrmSysContext, in DealEvent inDealEvent)
                {

                }

                public static void AlterClientNotation(in CrmSysContext inCrmSysContext, in ClientNotation inClientNotation)
                {

                }

                public static void AlterDirectorAcctLogPwd(in CrmSysContext inCrmSysContext, in DirectorAcctLogPwd inDirectorAcctLogPwd)
                {

                }

                public static void AlterManagerAcctLogPwd(in CrmSysContext inCrmSysContext, in ManagerAcctLogPwd inManagerAcctLogPwd)
                {

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
                    return null;
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

                public static ICollection<DealEvent> GetManagerDealsEventsForToday(in CrmSysContext inCrmSysContext, int inManagerId)
                {
                    return null;
                }
            }
        }
    }
}
