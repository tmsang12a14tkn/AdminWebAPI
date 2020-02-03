using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class Agencies :BaseEntity
    {
        public Agencies()
        {
            AgencyBanks = new HashSet<AgencyBanks>();
            AgencyCares = new HashSet<AgencyCares>();
            AgencyDeliveries = new HashSet<AgencyDeliveries>();
            AgencyPayments = new HashSet<AgencyPayments>();
            AgencyRepresentatives = new HashSet<AgencyRepresentatives>();
            Orders = new HashSet<Orders>();
            Persons = new HashSet<Persons>();
        }

        public int AgencyType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TradingName { get; set; }
        public string TaxCode { get; set; }
        public string BusinessRegNumber { get; set; }
        public DateTime StartDate { get; set; }
        public int? AgencyGroupId { get; set; }
        public int? AgencyBusinessId { get; set; }

        public AgencyBusinesses AgencyBusiness { get; set; }
        public AgencyGroups AgencyGroup { get; set; }
        public AgencyContactInfos AgencyContactInfos { get; set; }
        public ICollection<AgencyBanks> AgencyBanks { get; set; }
        public ICollection<AgencyCares> AgencyCares { get; set; }
        public ICollection<AgencyDeliveries> AgencyDeliveries { get; set; }
        public ICollection<AgencyPayments> AgencyPayments { get; set; }
        public ICollection<AgencyRepresentatives> AgencyRepresentatives { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public ICollection<Persons> Persons { get; set; }
    }
}
