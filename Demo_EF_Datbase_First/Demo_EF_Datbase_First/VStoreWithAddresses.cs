﻿using System;
using System.Collections.Generic;

namespace Demo_EF_Datbase_First
{
    public partial class VStoreWithAddresses
    {
        public int BusinessEntityId { get; set; }
        public string Name { get; set; }
        public string AddressType { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvinceName { get; set; }
        public string PostalCode { get; set; }
        public string CountryRegionName { get; set; }
    }
}
