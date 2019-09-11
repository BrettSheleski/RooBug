using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Geo
{
	public partial class CityIpAddres {

		public virtual string CityIpAddressId { get; set; }

		public virtual int CityId { get; set; }

		public virtual string Network { get; set; }

		public virtual string IpAddressStart { get; set; }

		public virtual string IpAddressEnd { get; set; }

		public virtual string IpAddressStartNumeric { get; set; }

		public virtual string IpAddressEndNumeric { get; set; }
	}
}
