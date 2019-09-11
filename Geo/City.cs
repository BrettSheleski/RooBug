using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Geo
{
	public partial class City {

		public virtual int CityId { get; set; }

		public virtual string Name { get; set; }

		public virtual string CountryCode { get; set; }

		public virtual string IsActive { get; set; }

		public virtual string Population { get; set; }

		public virtual string Latitude { get; set; }

		public virtual string Longitude { get; set; }

		public virtual int Elevation { get; set; }

		public virtual string Timezone { get; set; }

		public virtual int GeonameId { get; set; }

		public virtual string AsciiName { get; set; }

		public virtual int StateId { get; set; }
	}
}
