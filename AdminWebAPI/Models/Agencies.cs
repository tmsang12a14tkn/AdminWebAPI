using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class Agencies
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

        public int Id { get; set; }
        public int AgencyType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TradingName { get; set; }
        public string TaxCode { get; set; }
        public string BusinessRegNumber { get; set; }
        public DateTime StartDate { get; set; }
        public int? AgencyGroupId { get; set; }
        public int? AgencyBusinessId { get; set; }

        public virtual AgencyBusinesses AgencyBusiness { get; set; }
        public virtual AgencyGroups AgencyGroup { get; set; }
        public virtual AgencyContactInfos AgencyContactInfos { get; set; }
        public virtual ICollection<AgencyBanks> AgencyBanks { get; set; }
        public virtual ICollection<AgencyCares> AgencyCares { get; set; }
        public virtual ICollection<AgencyDeliveries> AgencyDeliveries { get; set; }
        public virtual ICollection<AgencyPayments> AgencyPayments { get; set; }
        public virtual ICollection<AgencyRepresentatives> AgencyRepresentatives { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Persons> Persons { get; set; }
    }
}
