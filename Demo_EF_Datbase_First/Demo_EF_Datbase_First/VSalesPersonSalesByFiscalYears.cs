using System;
using System.Collections.Generic;

namespace Demo_EF_Datbase_First
{
    public partial class VSalesPersonSalesByFiscalYears
    {
        public int? SalesPersonId { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string SalesTerritory { get; set; }
        public decimal? _2002 { get; set; }
        public decimal? _2003 { get; set; }
        public decimal? _2004 { get; set; }
    }
}
