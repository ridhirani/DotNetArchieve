using System;
using System.Collections.Generic;

namespace Demo_EF_Datbase_First
{
    public partial class Currency
    {
        public Currency()
        {
            CountryRegionCurrency = new HashSet<CountryRegionCurrency>();
            CurrencyRateFromCurrencyCodeNavigation = new HashSet<CurrencyRate>();
            CurrencyRateToCurrencyCodeNavigation = new HashSet<CurrencyRate>();
        }

        public string CurrencyCode { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRateFromCurrencyCodeNavigation { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRateToCurrencyCodeNavigation { get; set; }
    }
}
