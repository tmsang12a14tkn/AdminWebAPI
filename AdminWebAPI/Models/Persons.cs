using System;
using System.Collections.Generic;

namespace AdminWebAPI.Models
{
    public partial class Persons
    {
        public Persons()
        {
            AgencyCares = new HashSet<AgencyCares>();
            AgencyRepresentatives = new HashSet<AgencyRepresentatives>();
            Idcards = new HashSet<Idcards>();
            Iddocuments = new HashSet<Iddocuments>();
            InverseCustomerSourceEmp = new HashSet<Persons>();
            MaritalStatuses = new HashSet<MaritalStatuses>();
            Orders = new HashSet<Orders>();
            Passports = new HashSet<Passports>();
            PersonBanks = new HashSet<PersonBanks>();
            PersonCustomerCaresEmployee = new HashSet<PersonCustomerCares>();
            PersonCustomerCaresPerson = new HashSet<PersonCustomerCares>();
            PersonCustomerWorkings = new HashSet<PersonCustomerWorkings>();
            PersonEmployeeWorkings = new HashSet<PersonEmployeeWorkings>();
            PersonalDobs = new HashSet<PersonalDobs>();
            PersonalNames = new HashSet<PersonalNames>();
            PersonalNationality = new HashSet<PersonalNationality>();
            PersonalPhotos = new HashSet<PersonalPhotos>();
            VehicleInfos = new HashSet<VehicleInfos>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public int TitlePrefixType { get; set; }
        public int PersonType { get; set; }
        public int GenderId { get; set; }
        public int? EthnicId { get; set; }
        public int? ReligionId { get; set; }
        public int? PersonLevelId { get; set; }
        public int? PersonCustomerSourceTypeId { get; set; }
        public int? CustomerSourceEmpId { get; set; }
        public int? AgencyId { get; set; }
        public string CustomerSourceNote { get; set; }
        public bool IsDeleted { get; set; }
        public string PrimaryName { get; set; }
        public string PrimaryDob { get; set; }
        public string PrimaryPhoto { get; set; }
        public int? CustomerSourceCusId { get; set; }
        public int? SocialTypeId { get; set; }

        public virtual Agencies Agency { get; set; }
        public virtual Persons CustomerSourceCus { get; set; }
        public virtual Persons CustomerSourceEmp { get; set; }
        public virtual Ethnics Ethnic { get; set; }
        public virtual PersonCustomerSourceTypes PersonCustomerSourceType { get; set; }
        public virtual PersonLevels PersonLevel { get; set; }
        public virtual Religions Religion { get; set; }
        public virtual SocialTypes SocialType { get; set; }
        //public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual ContactInfos ContactInfos { get; set; }
        public virtual Persons InverseCustomerSourceCus { get; set; }
        public virtual PersonalHomeTowns PersonalHomeTowns { get; set; }
        public virtual PersonalPobs PersonalPobs { get; set; }
        public virtual ICollection<AgencyCares> AgencyCares { get; set; }
        public virtual ICollection<AgencyRepresentatives> AgencyRepresentatives { get; set; }
        public virtual ICollection<Idcards> Idcards { get; set; }
        public virtual ICollection<Iddocuments> Iddocuments { get; set; }
        public virtual ICollection<Persons> InverseCustomerSourceEmp { get; set; }
        public virtual ICollection<MaritalStatuses> MaritalStatuses { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Passports> Passports { get; set; }
        public virtual ICollection<PersonBanks> PersonBanks { get; set; }
        public virtual ICollection<PersonCustomerCares> PersonCustomerCaresEmployee { get; set; }
        public virtual ICollection<PersonCustomerCares> PersonCustomerCaresPerson { get; set; }
        public virtual ICollection<PersonCustomerWorkings> PersonCustomerWorkings { get; set; }
        public virtual ICollection<PersonEmployeeWorkings> PersonEmployeeWorkings { get; set; }
        public virtual ICollection<PersonalDobs> PersonalDobs { get; set; }
        public virtual ICollection<PersonalNames> PersonalNames { get; set; }
        public virtual ICollection<PersonalNationality> PersonalNationality { get; set; }
        public virtual ICollection<PersonalPhotos> PersonalPhotos { get; set; }
        public virtual ICollection<VehicleInfos> VehicleInfos { get; set; }
    }
}
