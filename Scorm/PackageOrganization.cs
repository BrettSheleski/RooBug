using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class PackageOrganization {

		public virtual string ScormPackageOrganizationId { get; set; }

		public virtual string ScormPackageId { get; set; }

		public virtual string Identifier { get; set; }

		public virtual string IsDefault { get; set; }

		public virtual string Title { get; set; }
	}
}
