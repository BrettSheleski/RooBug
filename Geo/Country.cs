using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Geo
{
	public partial class Country {

		public virtual string CountryCode { get; set; }

		public virtual string Name { get; set; }

		public virtual string IsActive { get; set; }

		public virtual string Latitude { get; set; }

		public virtual string Longitude { get; set; }

		public virtual string FormalName { get; set; }

		public virtual string Iso3Code { get; set; }

		public virtual string IsoNumericCode { get; set; }

		public virtual string FipsCode { get; set; }

		public virtual string Capital { get; set; }

		public virtual string AreaSqKm { get; set; }

		public virtual string Population { get; set; }

		public virtual string ContinentCode { get; set; }

		public virtual string Tld { get; set; }

		public virtual string CurrencyCode { get; set; }

		public virtual string CurrencyName { get; set; }

		public virtual string Phone { get; set; }

		public virtual string PostalCodeFormat { get; set; }

		public virtual string PostalCodeRegex { get; set; }

		public virtual int GeonameId { get; set; }
	}
}
