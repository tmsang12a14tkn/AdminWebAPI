﻿using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class Persons : BaseEntity
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

        public Agencies Agency { get; set; }
        public Persons CustomerSourceCus { get; set; }
        public Persons CustomerSourceEmp { get; set; }
        public Ethnics Ethnic { get; set; }
        public PersonCustomerSourceTypes PersonCustomerSourceType { get; set; }
        public PersonLevels PersonLevel { get; set; }
        public Religions Religion { get; set; }
        public SocialTypes SocialType { get; set; }
        public ContactInfos ContactInfos { get; set; }
        public Persons InverseCustomerSourceCus { get; set; }
        public PersonalHomeTowns PersonalHomeTowns { get; set; }
        public PersonalPobs PersonalPobs { get; set; }
        public ICollection<AgencyCares> AgencyCares { get; set; }
        public ICollection<AgencyRepresentatives> AgencyRepresentatives { get; set; }
        public ICollection<Idcards> Idcards { get; set; }
        public ICollection<Iddocuments> Iddocuments { get; set; }
        public ICollection<Persons> InverseCustomerSourceEmp { get; set; }
        public ICollection<MaritalStatuses> MaritalStatuses { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public ICollection<Passports> Passports { get; set; }
        public ICollection<PersonBanks> PersonBanks { get; set; }
        public ICollection<PersonCustomerCares> PersonCustomerCaresEmployee { get; set; }
        public ICollection<PersonCustomerCares> PersonCustomerCaresPerson { get; set; }
        public ICollection<PersonCustomerWorkings> PersonCustomerWorkings { get; set; }
        public ICollection<PersonEmployeeWorkings> PersonEmployeeWorkings { get; set; }
        public ICollection<PersonalDobs> PersonalDobs { get; set; }
        public ICollection<PersonalNames> PersonalNames { get; set; }
        public ICollection<PersonalNationality> PersonalNationality { get; set; }
        public ICollection<PersonalPhotos> PersonalPhotos { get; set; }
        public ICollection<VehicleInfos> VehicleInfos { get; set; }
    }
}
