using System;
using Data.Manage.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Repo.Manage
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public int? PersonId { get; set; }
    }

    public partial class NinjaSaiGonContext : IdentityDbContext<ApplicationUser>
    {
        public NinjaSaiGonContext()
        {
        }

        public NinjaSaiGonContext(DbContextOptions<NinjaSaiGonContext> options)
            : base(options)
        {
        }
        public virtual DbSet<AddressTypes> AddressTypes { get; set; }
        public virtual DbSet<Agencies> Agencies { get; set; }
        public virtual DbSet<AgencyBankCards> AgencyBankCards { get; set; }
        public virtual DbSet<AgencyBanks> AgencyBanks { get; set; }
        public virtual DbSet<AgencyBusinesses> AgencyBusinesses { get; set; }
        public virtual DbSet<AgencyCares> AgencyCares { get; set; }
        public virtual DbSet<AgencyContactAddresses> AgencyContactAddresses { get; set; }
        public virtual DbSet<AgencyContactEmails> AgencyContactEmails { get; set; }
        public virtual DbSet<AgencyContactInfos> AgencyContactInfos { get; set; }
        public virtual DbSet<AgencyContactOtts> AgencyContactOtts { get; set; }
        public virtual DbSet<AgencyContactPhones> AgencyContactPhones { get; set; }
        public virtual DbSet<AgencyContactSocials> AgencyContactSocials { get; set; }
        public virtual DbSet<AgencyDeliveries> AgencyDeliveries { get; set; }
        public virtual DbSet<AgencyDiscountCustomerTypes> AgencyDiscountCustomerTypes { get; set; }
        public virtual DbSet<AgencyDiscountTypes> AgencyDiscountTypes { get; set; }
        public virtual DbSet<AgencyGroups> AgencyGroups { get; set; }
        public virtual DbSet<AgencyPayments> AgencyPayments { get; set; }
        public virtual DbSet<AgencyRepresentatives> AgencyRepresentatives { get; set; }
        public virtual DbSet<BankAccountTypes> BankAccountTypes { get; set; }
        public virtual DbSet<BankCards> BankCards { get; set; }
        public virtual DbSet<BankCardTypes> BankCardTypes { get; set; }
        public virtual DbSet<BusinessAreas> BusinessAreas { get; set; }
        public virtual DbSet<CategoryIceOption> CategoryIceOption { get; set; }
        public virtual DbSet<CategorySugarOption> CategorySugarOption { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<CommissionFormulas> CommissionFormulas { get; set; }
        public virtual DbSet<Companies> Companies { get; set; }
        public virtual DbSet<ContactAddresses> ContactAddresses { get; set; }
        public virtual DbSet<ContactEmails> ContactEmails { get; set; }
        public virtual DbSet<ContactInfos> ContactInfos { get; set; }
        public virtual DbSet<ContactOtts> ContactOtts { get; set; }
        public virtual DbSet<ContactPhones> ContactPhones { get; set; }
        public virtual DbSet<ContactSocials> ContactSocials { get; set; }
        public virtual DbSet<ControllerActionPermissions> ControllerActionPermissions { get; set; }
        public virtual DbSet<ControllerActions> ControllerActions { get; set; }
        public virtual DbSet<CurrencyTypes> CurrencyTypes { get; set; }
        public virtual DbSet<DeliveryPartners> DeliveryPartners { get; set; }
        public virtual DbSet<DepartmentPositions> DepartmentPositions { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Devices> Devices { get; set; }
        public virtual DbSet<DistrictPlaces> DistrictPlaces { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<DrinkCategories> DrinkCategories { get; set; }
        public virtual DbSet<DrinkCategoryPhotos> DrinkCategoryPhotos { get; set; }
        public virtual DbSet<DrinkCategoryTypes> DrinkCategoryTypes { get; set; }
        public virtual DbSet<DrinkPhotos> DrinkPhotos { get; set; }
        public virtual DbSet<Drinks> Drinks { get; set; }
        public virtual DbSet<DrinkSizes> DrinkSizes { get; set; }
        public virtual DbSet<DrinkToppingCategories> DrinkToppingCategories { get; set; }
        public virtual DbSet<DrinkToppings> DrinkToppings { get; set; }
        public virtual DbSet<DrinkUnits> DrinkUnits { get; set; }
        public virtual DbSet<EmailTypes> EmailTypes { get; set; }
        public virtual DbSet<Ethnics> Ethnics { get; set; }
        public virtual DbSet<FreeDrinkReasons> FreeDrinkReasons { get; set; }
        public virtual DbSet<IceOptions> IceOptions { get; set; }
        public virtual DbSet<Idcards> Idcards { get; set; }
        public virtual DbSet<Iddocuments> Iddocuments { get; set; }
        public virtual DbSet<IddocumentTypes> IddocumentTypes { get; set; }
        public virtual DbSet<MaritalStatuses> MaritalStatuses { get; set; }
        public virtual DbSet<MaritalStatusTypes> MaritalStatusTypes { get; set; }
        public virtual DbSet<Nationalities> Nationalities { get; set; }
        public virtual DbSet<NotifyPopups> NotifyPopups { get; set; }
        public virtual DbSet<OrderDeliveries> OrderDeliveries { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<OrderDetailToppings> OrderDetailToppings { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderSources> OrderSources { get; set; }
        public virtual DbSet<OrderSourceTypes> OrderSourceTypes { get; set; }
        public virtual DbSet<Otttypes> Otttypes { get; set; }
        public virtual DbSet<Passports> Passports { get; set; }
        public virtual DbSet<PaymentTermTypes> PaymentTermTypes { get; set; }
        public virtual DbSet<PaymentTypes> PaymentTypes { get; set; }
        public virtual DbSet<PersonalDobs> PersonalDobs { get; set; }
        public virtual DbSet<PersonalDobtypes> PersonalDobtypes { get; set; }
        public virtual DbSet<PersonalHomeTowns> PersonalHomeTowns { get; set; }
        public virtual DbSet<PersonalNames> PersonalNames { get; set; }
        public virtual DbSet<PersonalNameTypes> PersonalNameTypes { get; set; }
        public virtual DbSet<PersonalNationality> PersonalNationality { get; set; }
        public virtual DbSet<PersonalPhotos> PersonalPhotos { get; set; }
        public virtual DbSet<PersonalPhotoTypes> PersonalPhotoTypes { get; set; }
        public virtual DbSet<PersonalPobs> PersonalPobs { get; set; }
        public virtual DbSet<PersonBanks> PersonBanks { get; set; }
        public virtual DbSet<PersonCustomerCares> PersonCustomerCares { get; set; }
        public virtual DbSet<PersonCustomerSourceTypes> PersonCustomerSourceTypes { get; set; }
        public virtual DbSet<PersonCustomerWorkings> PersonCustomerWorkings { get; set; }
        public virtual DbSet<PersonEmployeeWorkings> PersonEmployeeWorkings { get; set; }
        public virtual DbSet<PersonLevels> PersonLevels { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<PhoneTypes> PhoneTypes { get; set; }
        public virtual DbSet<PickupTypes> PickupTypes { get; set; }
        public virtual DbSet<PrivatePromotionCodes> PrivatePromotionCodes { get; set; }
        public virtual DbSet<PrivatePromotionDrinks> PrivatePromotionDrinks { get; set; }
        public virtual DbSet<PrivatePromotionDrinkSettings> PrivatePromotionDrinkSettings { get; set; }
        public virtual DbSet<PrivatePromotionDrinkToppings> PrivatePromotionDrinkToppings { get; set; }
        public virtual DbSet<PrivatePromotionPhotos> PrivatePromotionPhotos { get; set; }
        public virtual DbSet<PrivatePromotions> PrivatePromotions { get; set; }
        public virtual DbSet<PromotionApplyHours> PromotionApplyHours { get; set; }
        public virtual DbSet<PromotionDrinks> PromotionDrinks { get; set; }
        public virtual DbSet<PromotionDrinkSettings> PromotionDrinkSettings { get; set; }
        public virtual DbSet<PromotionDrinkToppings> PromotionDrinkToppings { get; set; }
        public virtual DbSet<PromotionPhotos> PromotionPhotos { get; set; }
        public virtual DbSet<Promotions> Promotions { get; set; }
        public virtual DbSet<Provinces> Provinces { get; set; }
        public virtual DbSet<Religions> Religions { get; set; }
        public virtual DbSet<ShoppingCartItems> ShoppingCartItems { get; set; }
        public virtual DbSet<SocialTypes> SocialTypes { get; set; }
        public virtual DbSet<SugarOptions> SugarOptions { get; set; }
        public virtual DbSet<ToppingCategories> ToppingCategories { get; set; }
        public virtual DbSet<ToppingPhotos> ToppingPhotos { get; set; }
        public virtual DbSet<Toppings> Toppings { get; set; }
        public virtual DbSet<VehicleInfos> VehicleInfos { get; set; }
        public virtual DbSet<VehiclePhotos> VehiclePhotos { get; set; }
        public virtual DbSet<Wards> Wards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"Data Source=45.32.101.63;Initial Catalog=NinjaSaiGon;User ID=ninjasaigon;Password=Abc@@123;Persist Security Info=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agencies>(entity =>
            {
                entity.HasIndex(e => e.AgencyBusinessId);

                entity.HasIndex(e => e.AgencyGroupId);

                entity.HasOne(d => d.AgencyBusiness)
                    .WithMany(p => p.Agencies)
                    .HasForeignKey(d => d.AgencyBusinessId);

                entity.HasOne(d => d.AgencyGroup)
                    .WithMany(p => p.Agencies)
                    .HasForeignKey(d => d.AgencyGroupId);
            });

            modelBuilder.Entity<AgencyBankCards>(entity =>
            {
                entity.HasIndex(e => e.AgencyBankId);

                entity.HasIndex(e => e.BankCardTypeId);

                entity.HasOne(d => d.AgencyBank)
                    .WithMany(p => p.AgencyBankCards)
                    .HasForeignKey(d => d.AgencyBankId);

                entity.HasOne(d => d.BankCardType)
                    .WithMany(p => p.AgencyBankCards)
                    .HasForeignKey(d => d.BankCardTypeId);
            });

            modelBuilder.Entity<AgencyBanks>(entity =>
            {
                entity.HasIndex(e => e.AgencyId);

                entity.HasIndex(e => e.BankAccountTypeId);

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.AgencyBanks)
                    .HasForeignKey(d => d.AgencyId);

                entity.HasOne(d => d.BankAccountType)
                    .WithMany(p => p.AgencyBanks)
                    .HasForeignKey(d => d.BankAccountTypeId);
            });

            modelBuilder.Entity<AgencyCares>(entity =>
            {
                entity.HasIndex(e => e.AgencyId);

                entity.HasIndex(e => e.EmployeeId);

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.AgencyCares)
                    .HasForeignKey(d => d.AgencyId);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AgencyCares)
                    .HasForeignKey(d => d.EmployeeId);
            });

            modelBuilder.Entity<AgencyContactAddresses>(entity =>
            {
                entity.HasIndex(e => e.AgencyContactInfoId);

                entity.HasIndex(e => e.DistrictPlaceId);

                entity.HasIndex(e => e.NationalityId);

                entity.HasIndex(e => e.ProvinceId);

                entity.HasIndex(e => e.TypeId);

                entity.HasIndex(e => e.WardId);

                entity.HasOne(d => d.AgencyContactInfo)
                    .WithMany(p => p.AgencyContactAddresses)
                    .HasForeignKey(d => d.AgencyContactInfoId);

                entity.HasOne(d => d.DistrictPlace)
                    .WithMany(p => p.AgencyContactAddresses)
                    .HasForeignKey(d => d.DistrictPlaceId);

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.AgencyContactAddresses)
                    .HasForeignKey(d => d.NationalityId);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.AgencyContactAddresses)
                    .HasForeignKey(d => d.ProvinceId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.AgencyContactAddresses)
                    .HasForeignKey(d => d.TypeId);

                entity.HasOne(d => d.Ward)
                    .WithMany(p => p.AgencyContactAddresses)
                    .HasForeignKey(d => d.WardId);
            });

            modelBuilder.Entity<AgencyContactEmails>(entity =>
            {
                entity.HasIndex(e => e.AgencyContactInfoId);

                entity.HasIndex(e => e.TypeId);

                entity.HasOne(d => d.AgencyContactInfo)
                    .WithMany(p => p.AgencyContactEmails)
                    .HasForeignKey(d => d.AgencyContactInfoId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.AgencyContactEmails)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<AgencyContactInfos>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.AgencyContactInfos)
                    .HasForeignKey<AgencyContactInfos>(d => d.Id);
            });

            modelBuilder.Entity<AgencyContactOtts>(entity =>
            {
                entity.ToTable("AgencyContactOTTs");

                entity.HasIndex(e => e.AgencyContactInfoId);

                entity.HasIndex(e => e.TypeId);

                entity.HasOne(d => d.AgencyContactInfo)
                    .WithMany(p => p.AgencyContactOtts)
                    .HasForeignKey(d => d.AgencyContactInfoId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.AgencyContactOtts)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<AgencyContactPhones>(entity =>
            {
                entity.HasIndex(e => e.AgencyContactInfoId);

                entity.HasIndex(e => e.TypeId);

                entity.HasOne(d => d.AgencyContactInfo)
                    .WithMany(p => p.AgencyContactPhones)
                    .HasForeignKey(d => d.AgencyContactInfoId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.AgencyContactPhones)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<AgencyContactSocials>(entity =>
            {
                entity.HasIndex(e => e.AgencyContactInfoId);

                entity.HasIndex(e => e.TypeId);

                entity.HasOne(d => d.AgencyContactInfo)
                    .WithMany(p => p.AgencyContactSocials)
                    .HasForeignKey(d => d.AgencyContactInfoId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.AgencyContactSocials)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<AgencyDeliveries>(entity =>
            {
                entity.HasIndex(e => e.AgencyDiscountCustomerTypeId);

                entity.HasIndex(e => e.AgencyId);

                entity.HasIndex(e => e.PickupTypeId);

                entity.HasOne(d => d.AgencyDiscountCustomerType)
                    .WithMany(p => p.AgencyDeliveries)
                    .HasForeignKey(d => d.AgencyDiscountCustomerTypeId);

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.AgencyDeliveries)
                    .HasForeignKey(d => d.AgencyId);

                entity.HasOne(d => d.PickupType)
                    .WithMany(p => p.AgencyDeliveries)
                    .HasForeignKey(d => d.PickupTypeId);
            });

            modelBuilder.Entity<AgencyPayments>(entity =>
            {
                entity.HasIndex(e => e.AgencyDiscountTypeId);

                entity.HasIndex(e => e.AgencyId);

                entity.HasIndex(e => e.CurrencyTypeId);

                entity.HasIndex(e => e.PaymentTermTypeId);

                entity.HasIndex(e => e.PaymentTypeId);

                entity.HasOne(d => d.AgencyDiscountType)
                    .WithMany(p => p.AgencyPayments)
                    .HasForeignKey(d => d.AgencyDiscountTypeId);

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.AgencyPayments)
                    .HasForeignKey(d => d.AgencyId);

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.AgencyPayments)
                    .HasForeignKey(d => d.CurrencyTypeId);

                entity.HasOne(d => d.PaymentTermType)
                    .WithMany(p => p.AgencyPayments)
                    .HasForeignKey(d => d.PaymentTermTypeId);

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.AgencyPayments)
                    .HasForeignKey(d => d.PaymentTypeId);
            });

            modelBuilder.Entity<AgencyRepresentatives>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.AgencyId });

                entity.HasIndex(e => e.AgencyId);

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.AgencyRepresentatives)
                    .HasForeignKey(d => d.AgencyId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.AgencyRepresentatives)
                    .HasForeignKey(d => d.PersonId);
            });

            

            modelBuilder.Entity<BankCards>(entity =>
            {
                entity.HasIndex(e => e.BankCardTypeId);

                entity.HasIndex(e => e.PersonBankId);

                entity.HasOne(d => d.BankCardType)
                    .WithMany(p => p.BankCards)
                    .HasForeignKey(d => d.BankCardTypeId);

                entity.HasOne(d => d.PersonBank)
                    .WithMany(p => p.BankCards)
                    .HasForeignKey(d => d.PersonBankId);
            });

            modelBuilder.Entity<BusinessAreas>(entity =>
            {
                entity.HasIndex(e => e.ParentId);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<CategoryIceOption>(entity =>
            {
                entity.HasIndex(e => e.DrinkCategoryId);

                entity.HasOne(d => d.DrinkCategory)
                    .WithMany(p => p.CategoryIceOption)
                    .HasForeignKey(d => d.DrinkCategoryId);
            });

            modelBuilder.Entity<CategorySugarOption>(entity =>
            {
                entity.HasIndex(e => e.DrinkCategoryId);

                entity.HasOne(d => d.DrinkCategory)
                    .WithMany(p => p.CategorySugarOption)
                    .HasForeignKey(d => d.DrinkCategoryId);
            });

            modelBuilder.Entity<ContactAddresses>(entity =>
            {
                entity.HasIndex(e => e.ContactInfoId);

                entity.HasIndex(e => e.DistrictPlaceId);

                entity.HasIndex(e => e.NationalityId);

                entity.HasIndex(e => e.ProvinceId);

                entity.HasIndex(e => e.TypeId);

                entity.HasIndex(e => e.WardId);

                entity.HasOne(d => d.ContactInfo)
                    .WithMany(p => p.ContactAddresses)
                    .HasForeignKey(d => d.ContactInfoId);

                entity.HasOne(d => d.DistrictPlace)
                    .WithMany(p => p.ContactAddresses)
                    .HasForeignKey(d => d.DistrictPlaceId);

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.ContactAddresses)
                    .HasForeignKey(d => d.NationalityId);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.ContactAddresses)
                    .HasForeignKey(d => d.ProvinceId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ContactAddresses)
                    .HasForeignKey(d => d.TypeId);

                entity.HasOne(d => d.Ward)
                    .WithMany(p => p.ContactAddresses)
                    .HasForeignKey(d => d.WardId);
            });

            modelBuilder.Entity<ContactEmails>(entity =>
            {
                entity.HasIndex(e => e.ContactInfoId);

                entity.HasIndex(e => e.TypeId);

                entity.HasOne(d => d.ContactInfo)
                    .WithMany(p => p.ContactEmails)
                    .HasForeignKey(d => d.ContactInfoId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ContactEmails)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<ContactInfos>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ContactInfos)
                    .HasForeignKey<ContactInfos>(d => d.Id);
            });

            modelBuilder.Entity<ContactOtts>(entity =>
            {
                entity.ToTable("ContactOTTs");

                entity.HasIndex(e => e.ContactInfoId);

                entity.HasIndex(e => e.TypeId);

                entity.HasOne(d => d.ContactInfo)
                    .WithMany(p => p.ContactOtts)
                    .HasForeignKey(d => d.ContactInfoId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ContactOtts)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<ContactPhones>(entity =>
            {
                entity.HasIndex(e => e.ContactInfoId);

                entity.HasIndex(e => e.TypeId);

                entity.HasOne(d => d.ContactInfo)
                    .WithMany(p => p.ContactPhones)
                    .HasForeignKey(d => d.ContactInfoId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ContactPhones)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<ContactSocials>(entity =>
            {
                entity.HasIndex(e => e.ContactInfoId);

                entity.HasIndex(e => e.TypeId);

                entity.HasOne(d => d.ContactInfo)
                    .WithMany(p => p.ContactSocials)
                    .HasForeignKey(d => d.ContactInfoId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ContactSocials)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<ControllerActionPermissions>(entity =>
            {
                entity.HasKey(e => new { e.ControllerActionId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.ControllerAction)
                    .WithMany(p => p.ControllerActionPermissions)
                    .HasForeignKey(d => d.ControllerActionId);

                //entity.HasOne(d => d.Role)
                //    .WithMany(p => p.ControllerActionPermissions)
                //    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<ControllerActions>(entity =>
            {
                entity.Property(e => e.IsShow).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DepartmentPositions>(entity =>
            {
                entity.HasIndex(e => e.DepartmentId);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentPositions)
                    .HasForeignKey(d => d.DepartmentId);
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasIndex(e => e.CompanyId);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.CompanyId);
            });

            modelBuilder.Entity<Devices>(entity =>
            {
                entity.Property(e => e.PushP256dh).HasColumnName("PushP256DH");
            });

            modelBuilder.Entity<DistrictPlaces>(entity =>
            {
                entity.HasIndex(e => e.ProvinceId);

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.DistrictPlaces)
                    .HasForeignKey(d => d.ProvinceId);
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.HasIndex(e => e.CityId);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.CityId);
            });

            modelBuilder.Entity<DrinkCategories>(entity =>
            {
                entity.HasIndex(e => e.ParentId);

                entity.HasIndex(e => e.TypeId);

                entity.Property(e => e.Position).HasDefaultValueSql("((0))");

                entity.Property(e => e.TypeId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.DrinkCategories)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<DrinkCategoryPhotos>(entity =>
            {
                entity.HasIndex(e => e.DrinkCategoryId);

                entity.HasOne(d => d.DrinkCategory)
                    .WithMany(p => p.DrinkCategoryPhotos)
                    .HasForeignKey(d => d.DrinkCategoryId);
            });

            modelBuilder.Entity<DrinkPhotos>(entity =>
            {
                entity.HasIndex(e => e.DrinkId);

                entity.HasOne(d => d.Drink)
                    .WithMany(p => p.DrinkPhotos)
                    .HasForeignKey(d => d.DrinkId);
            });

            modelBuilder.Entity<Drinks>(entity =>
            {
                entity.HasIndex(e => e.CategoryId);

                entity.Property(e => e.NewOrderSort).HasDefaultValueSql("((0))");

                entity.Property(e => e.Position).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Drinks)
                    .HasForeignKey(d => d.CategoryId);
            });

            modelBuilder.Entity<DrinkSizes>(entity =>
            {
                entity.HasIndex(e => e.DrinkId);

                entity.HasIndex(e => e.UnitId);

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");

                entity.Property(e => e.Quota).HasDefaultValueSql("(CONVERT([real],(0)))");

                entity.HasOne(d => d.Drink)
                    .WithMany(p => p.DrinkSizes)
                    .HasForeignKey(d => d.DrinkId);

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.DrinkSizes)
                    .HasForeignKey(d => d.UnitId);
            });

            modelBuilder.Entity<DrinkToppingCategories>(entity =>
            {
                entity.HasKey(e => new { e.DrinkId, e.ToppingCategoryId });

                entity.HasIndex(e => e.ToppingCategoryId);

                entity.HasOne(d => d.Drink)
                    .WithMany(p => p.DrinkToppingCategories)
                    .HasForeignKey(d => d.DrinkId);

                entity.HasOne(d => d.ToppingCategory)
                    .WithMany(p => p.DrinkToppingCategories)
                    .HasForeignKey(d => d.ToppingCategoryId);
            });

            modelBuilder.Entity<DrinkToppings>(entity =>
            {
                entity.HasKey(e => new { e.DrinkId, e.ToppingId });

                entity.HasIndex(e => e.ToppingId);

                entity.HasOne(d => d.Drink)
                    .WithMany(p => p.DrinkToppings)
                    .HasForeignKey(d => d.DrinkId);

                entity.HasOne(d => d.Topping)
                    .WithMany(p => p.DrinkToppings)
                    .HasForeignKey(d => d.ToppingId);
            });

            modelBuilder.Entity<IceOptions>(entity =>
            {
                entity.HasIndex(e => e.DrinkId);

                entity.HasIndex(e => e.UnitId);

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");

                entity.Property(e => e.Quota).HasDefaultValueSql("(CONVERT([real],(0)))");

                entity.HasOne(d => d.Drink)
                    .WithMany(p => p.IceOptions)
                    .HasForeignKey(d => d.DrinkId);

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.IceOptions)
                    .HasForeignKey(d => d.UnitId);
            });

            modelBuilder.Entity<Idcards>(entity =>
            {
                entity.ToTable("IDCards");

                entity.HasIndex(e => e.PersonId);

                entity.Property(e => e.Idnumber).HasColumnName("IDNumber");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Idcards)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<Iddocuments>(entity =>
            {
                entity.ToTable("IDDocuments");

                entity.HasIndex(e => e.IddocumentTypeId);

                entity.HasIndex(e => e.PersonId);

                entity.Property(e => e.IddocumentTypeId).HasColumnName("IDDocumentTypeId");

                entity.Property(e => e.Idnumber).HasColumnName("IDNumber");

                entity.HasOne(d => d.IddocumentType)
                    .WithMany(p => p.Iddocuments)
                    .HasForeignKey(d => d.IddocumentTypeId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Iddocuments)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<IddocumentTypes>(entity =>
            {
                entity.ToTable("IDDocumentTypes");
            });

            modelBuilder.Entity<MaritalStatuses>(entity =>
            {
                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.TypeId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.MaritalStatuses)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.MaritalStatuses)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<OrderDeliveries>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.HasIndex(e => e.DeliveryPartnerId);

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Partner).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartnerShipFee).HasDefaultValueSql("((0))");

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.HasOne(d => d.DeliveryPartner)
                    .WithMany(p => p.OrderDeliveries)
                    .HasForeignKey(d => d.DeliveryPartnerId);

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.OrderDeliveries)
                    .HasForeignKey<OrderDeliveries>(d => d.OrderId);
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId);

                entity.HasIndex(e => e.FreeDrinkReasonId);

                entity.HasIndex(e => e.OrderId);

                entity.Property(e => e.DiscountMoneyValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountPercentValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountType).HasDefaultValueSql("((0))");

                entity.Property(e => e.DrinkSizeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.FullPrice).HasDefaultValueSql("((0))");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.FreeDrinkReason)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.FreeDrinkReasonId);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId);
            });

            modelBuilder.Entity<OrderDetailToppings>(entity =>
            {
                entity.HasKey(e => new { e.OrderDetailId, e.ToppingId });

                entity.HasIndex(e => e.ToppingId);

                entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.OrderDetailToppings)
                    .HasForeignKey(d => d.OrderDetailId);

                entity.HasOne(d => d.Topping)
                    .WithMany(p => p.OrderDetailToppings)
                    .HasForeignKey(d => d.ToppingId);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.HasIndex(e => e.AgencyId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.DistrictId);

                entity.HasIndex(e => e.OrderSourceId);

                entity.Property(e => e.AddressLine).HasMaxLength(100);

                entity.Property(e => e.BaseDrinkCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardCode).HasMaxLength(50);

                entity.Property(e => e.DiscountAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountDrinkCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Distance).HasDefaultValueSql("((0))");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FreeDrinkCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.OrderCustomerType).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderDeliveried).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.Property(e => e.PromotionDiscountType).HasDefaultValueSql("((0))");

                entity.Property(e => e.PromotionDiscountValue).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShipFee).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.SurchargeAmount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AgencyId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.DistrictId);

                entity.HasOne(d => d.OrderSource)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderSourceId);
            });

            modelBuilder.Entity<OrderSources>(entity =>
            {
                entity.HasIndex(e => e.OrderSourceTypeId);

                entity.HasOne(d => d.OrderSourceType)
                    .WithMany(p => p.OrderSources)
                    .HasForeignKey(d => d.OrderSourceTypeId);
            });

            modelBuilder.Entity<Otttypes>(entity =>
            {
                entity.ToTable("OTTTypes");
            });

            modelBuilder.Entity<Passports>(entity =>
            {
                entity.HasIndex(e => e.PersonId);

                entity.Property(e => e.Idnumber).HasColumnName("IDNumber");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Passports)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<PersonalDobs>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.TypeId });

                entity.ToTable("PersonalDOBs");

                entity.HasIndex(e => e.TypeId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonalDobs)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PersonalDobs)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<PersonalDobtypes>(entity =>
            {
                entity.ToTable("PersonalDOBTypes");
            });

            modelBuilder.Entity<PersonalHomeTowns>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.Property(e => e.PersonId).ValueGeneratedNever();

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.PersonalHomeTowns)
                    .HasForeignKey<PersonalHomeTowns>(d => d.PersonId);
            });

            modelBuilder.Entity<PersonalNames>(entity =>
            {
                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.TypeId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonalNames)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PersonalNames)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<PersonalNationality>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.NationalityId });

                entity.HasIndex(e => e.NationalityId);

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.PersonalNationality)
                    .HasForeignKey(d => d.NationalityId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonalNationality)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<PersonalPhotos>(entity =>
            {
                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.TypeId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonalPhotos)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PersonalPhotos)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<PersonalPobs>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.ToTable("PersonalPOBs");

                entity.Property(e => e.PersonId).ValueGeneratedNever();

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.PersonalPobs)
                    .HasForeignKey<PersonalPobs>(d => d.PersonId);
            });

            modelBuilder.Entity<PersonBanks>(entity =>
            {
                entity.HasIndex(e => e.BankAccountTypeId);

                entity.HasIndex(e => e.PersonId);

                entity.HasOne(d => d.BankAccountType)
                    .WithMany(p => p.PersonBanks)
                    .HasForeignKey(d => d.BankAccountTypeId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonBanks)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<PersonCustomerCares>(entity =>
            {
                entity.HasIndex(e => e.EmployeeId);

                entity.HasIndex(e => e.PersonId);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PersonCustomerCaresEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonCustomerCaresPerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PersonCustomerWorkings>(entity =>
            {
                entity.HasIndex(e => e.PersonId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonCustomerWorkings)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<PersonEmployeeWorkings>(entity =>
            {
                entity.HasIndex(e => e.DepartmentId);

                entity.HasIndex(e => e.DepartmentPositionId);

                entity.HasIndex(e => e.PersonId);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.PersonEmployeeWorkings)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.DepartmentPosition)
                    .WithMany(p => p.PersonEmployeeWorkings)
                    .HasForeignKey(d => d.DepartmentPositionId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonEmployeeWorkings)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.HasIndex(e => e.AgencyId);

                entity.HasIndex(e => e.CustomerSourceCusId)
                    .IsUnique()
                    .HasFilter("([CustomerSourceCusId] IS NOT NULL)");

                entity.HasIndex(e => e.CustomerSourceEmpId);

                entity.HasIndex(e => e.EthnicId);

                entity.HasIndex(e => e.PersonCustomerSourceTypeId);

                entity.HasIndex(e => e.PersonLevelId);

                entity.HasIndex(e => e.ReligionId);

                entity.HasIndex(e => e.SocialTypeId);

                entity.Property(e => e.PrimaryDob).HasColumnName("PrimaryDOB");

                entity.HasOne(d => d.Agency)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.AgencyId);

                entity.HasOne(d => d.CustomerSourceCus)
                    .WithOne(p => p.InverseCustomerSourceCus)
                    .HasForeignKey<Persons>(d => d.CustomerSourceCusId);

                entity.HasOne(d => d.CustomerSourceEmp)
                    .WithMany(p => p.InverseCustomerSourceEmp)
                    .HasForeignKey(d => d.CustomerSourceEmpId);

                entity.HasOne(d => d.Ethnic)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.EthnicId);

                entity.HasOne(d => d.PersonCustomerSourceType)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.PersonCustomerSourceTypeId);

                entity.HasOne(d => d.PersonLevel)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.PersonLevelId);

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.ReligionId);

                entity.HasOne(d => d.SocialType)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.SocialTypeId);
            });

            modelBuilder.Entity<PrivatePromotionCodes>(entity =>
            {
                entity.HasIndex(e => e.PrivatePromotionId);

                entity.HasOne(d => d.PrivatePromotion)
                    .WithMany(p => p.PrivatePromotionCodes)
                    .HasForeignKey(d => d.PrivatePromotionId);
            });

            modelBuilder.Entity<PrivatePromotionDrinks>(entity =>
            {
                entity.HasIndex(e => e.DrinkId);

                entity.HasIndex(e => e.PrivatePromotionId);

                entity.HasOne(d => d.Drink)
                    .WithMany(p => p.PrivatePromotionDrinks)
                    .HasForeignKey(d => d.DrinkId);

                entity.HasOne(d => d.PrivatePromotion)
                    .WithMany(p => p.PrivatePromotionDrinks)
                    .HasForeignKey(d => d.PrivatePromotionId);
            });

            modelBuilder.Entity<PrivatePromotionDrinkSettings>(entity =>
            {
                entity.HasKey(e => e.PrivatePromotionId);

                entity.Property(e => e.PrivatePromotionId).ValueGeneratedNever();

                entity.Property(e => e.ConditionMinDrink).HasColumnName("Condition_MinDrink");

                entity.Property(e => e.ConditionMinDrinkValue).HasColumnName("Condition_MinDrinkValue");

                entity.Property(e => e.ConditionMinMoney).HasColumnName("Condition_MinMoney");

                entity.Property(e => e.ConditionMinMoneyValue).HasColumnName("Condition_MinMoneyValue");

                entity.Property(e => e.ConditionTopping).HasColumnName("Condition_Topping");

                entity.Property(e => e.ConditionWithTopping).HasColumnName("Condition_WithTopping");

                entity.Property(e => e.FixedFreeDrinkQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.FreeDrinkOrderPrice)
                    .HasColumnName("FreeDrink_OrderPrice")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.PrivatePromotion)
                    .WithOne(p => p.PrivatePromotionDrinkSettings)
                    .HasForeignKey<PrivatePromotionDrinkSettings>(d => d.PrivatePromotionId);
            });

            modelBuilder.Entity<PrivatePromotionDrinkToppings>(entity =>
            {
                entity.HasIndex(e => e.PrivatePromotionDrinkId);

                entity.HasIndex(e => e.ToppingId);

                entity.HasOne(d => d.PrivatePromotionDrink)
                    .WithMany(p => p.PrivatePromotionDrinkToppings)
                    .HasForeignKey(d => d.PrivatePromotionDrinkId);

                entity.HasOne(d => d.Topping)
                    .WithMany(p => p.PrivatePromotionDrinkToppings)
                    .HasForeignKey(d => d.ToppingId);
            });

            modelBuilder.Entity<PrivatePromotionPhotos>(entity =>
            {
                entity.HasIndex(e => e.PrivatePromotionId);

                entity.HasOne(d => d.PrivatePromotion)
                    .WithMany(p => p.PrivatePromotionPhotos)
                    .HasForeignKey(d => d.PrivatePromotionId);
            });

            modelBuilder.Entity<PrivatePromotions>(entity =>
            {
                entity.Property(e => e.MaxDiscountMoney).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinMoney).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PromotionApplyHours>(entity =>
            {
                entity.HasIndex(e => e.PromotionId);

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.PromotionApplyHours)
                    .HasForeignKey(d => d.PromotionId);
            });

            modelBuilder.Entity<PromotionDrinks>(entity =>
            {
                entity.HasIndex(e => e.DrinkId);

                entity.HasIndex(e => e.PromotionId);

                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Drink)
                    .WithMany(p => p.PromotionDrinks)
                    .HasForeignKey(d => d.DrinkId);

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.PromotionDrinks)
                    .HasForeignKey(d => d.PromotionId);
            });

            modelBuilder.Entity<PromotionDrinkSettings>(entity =>
            {
                entity.HasKey(e => e.PromotionId);

                entity.Property(e => e.PromotionId).ValueGeneratedNever();

                entity.Property(e => e.ConditionMinDrink).HasColumnName("Condition_MinDrink");

                entity.Property(e => e.ConditionMinDrinkValue).HasColumnName("Condition_MinDrinkValue");

                entity.Property(e => e.ConditionMinMoney).HasColumnName("Condition_MinMoney");

                entity.Property(e => e.ConditionMinMoneyValue).HasColumnName("Condition_MinMoneyValue");

                entity.Property(e => e.ConditionTopping).HasColumnName("Condition_Topping");

                entity.Property(e => e.ConditionWithTopping).HasColumnName("Condition_WithTopping");

                entity.Property(e => e.FixedFreeDrinkQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.FreeDrinkOrderPrice)
                    .HasColumnName("FreeDrink_OrderPrice")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PromotionDrinkBuyQuantity).HasDefaultValueSql("((0))");

                entity.Property(e => e.PromotionDrinkGiveQuantity).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Promotion)
                    .WithOne(p => p.PromotionDrinkSettings)
                    .HasForeignKey<PromotionDrinkSettings>(d => d.PromotionId);
            });

            modelBuilder.Entity<PromotionDrinkToppings>(entity =>
            {
                entity.HasIndex(e => e.PromotionDrinkId);

                entity.HasIndex(e => e.ToppingId);

                entity.HasOne(d => d.PromotionDrink)
                    .WithMany(p => p.PromotionDrinkToppings)
                    .HasForeignKey(d => d.PromotionDrinkId);

                entity.HasOne(d => d.Topping)
                    .WithMany(p => p.PromotionDrinkToppings)
                    .HasForeignKey(d => d.ToppingId);
            });

            modelBuilder.Entity<PromotionPhotos>(entity =>
            {
                entity.HasIndex(e => e.PromotionId);

                entity.HasOne(d => d.Promotion)
                    .WithMany(p => p.PromotionPhotos)
                    .HasForeignKey(d => d.PromotionId);
            });

            modelBuilder.Entity<Promotions>(entity =>
            {
                entity.Property(e => e.MaxDiscountMoney).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinMoney).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ShoppingCartItems>(entity =>
            {
                entity.HasKey(e => e.ShoppingCartItemId);

                entity.HasIndex(e => e.DrinkId);

                entity.HasOne(d => d.Drink)
                    .WithMany(p => p.ShoppingCartItems)
                    .HasForeignKey(d => d.DrinkId);
            });

            modelBuilder.Entity<SugarOptions>(entity =>
            {
                entity.HasIndex(e => e.DrinkId);

                entity.HasIndex(e => e.UnitId);

                entity.Property(e => e.Order).HasDefaultValueSql("((0))");

                entity.Property(e => e.Quota).HasDefaultValueSql("(CONVERT([real],(0)))");

                entity.HasOne(d => d.Drink)
                    .WithMany(p => p.SugarOptions)
                    .HasForeignKey(d => d.DrinkId);

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.SugarOptions)
                    .HasForeignKey(d => d.UnitId);
            });

            modelBuilder.Entity<ToppingCategories>(entity =>
            {
                entity.HasIndex(e => e.ParentId);

                entity.Property(e => e.Position).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<ToppingPhotos>(entity =>
            {
                entity.HasIndex(e => e.ToppingId);

                entity.HasOne(d => d.Topping)
                    .WithMany(p => p.ToppingPhotos)
                    .HasForeignKey(d => d.ToppingId);
            });

            modelBuilder.Entity<Toppings>(entity =>
            {
                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.UnitId);

                entity.Property(e => e.CategoryId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Position).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuickCreateIndex).HasDefaultValueSql("((0))");

                entity.Property(e => e.Quota).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Toppings)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Toppings)
                    .HasForeignKey(d => d.UnitId);
            });

            modelBuilder.Entity<VehicleInfos>(entity =>
            {
                entity.HasIndex(e => e.PersonId);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.VehicleInfos)
                    .HasForeignKey(d => d.PersonId);
            });

            modelBuilder.Entity<VehiclePhotos>(entity =>
            {
                entity.HasIndex(e => e.VehicleInfoId);

                entity.HasOne(d => d.VehicleInfo)
                    .WithMany(p => p.VehiclePhotos)
                    .HasForeignKey(d => d.VehicleInfoId);
            });

            modelBuilder.Entity<Wards>(entity =>
            {
                entity.HasIndex(e => e.DistrictPlaceId);

                entity.HasOne(d => d.DistrictPlace)
                    .WithMany(p => p.Wards)
                    .HasForeignKey(d => d.DistrictPlaceId);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
