using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class PackageOrganizationItem {

		public virtual string ScormPackageOrganizationItemId { get; set; }

		public virtual string ScormPackageOrganizationId { get; set; }

		public virtual string Identifier { get; set; }

		public virtual string IdentifierRef { get; set; }

		public virtual string Title { get; set; }

		public virtual string ParentItemId { get; set; }
	}
}
