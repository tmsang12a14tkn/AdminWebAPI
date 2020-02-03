using System;
using System.Collections.Generic;

namespace Data.Manage.Models
{
    public partial class AgencyPayments
    {
        public int Id { get; set; }
        public int? PaymentTypeId { get; set; }
        public int? CurrencyTypeId { get; set; }
        public int? PaymentTermTypeId { get; set; }
        public int PaymentLimit { get; set; }
        public double InterestRate { get; set; }
        public int PaymentCredit { get; set; }
        public int InvoiceLimit { get; set; }
        public int? AgencyDiscountTypeId { get; set; }
        public double DiscountAmount { get; set; }
        public string Note { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int AgencyId { get; set; }

        public Agencies Agency { get; set; }
        public AgencyDiscountTypes AgencyDiscountType { get; set; }
        public CurrencyTypes CurrencyType { get; set; }
        public PaymentTermTypes PaymentTermType { get; set; }
        public PaymentTypes PaymentType { get; set; }
    }
}
