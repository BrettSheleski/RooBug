using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Geo
{
	public partial class Continent {

		public virtual string ContinentCode { get; set; }

		public virtual string Name { get; set; }

		public virtual string IsActive { get; set; }

		public virtual int GeonameId { get; set; }
	}
}
