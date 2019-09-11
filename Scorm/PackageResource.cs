using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class PackageResource {

		public virtual string ScormPackageResourceId { get; set; }

		public virtual string ScormPackageId { get; set; }

		public virtual string ScormPackageResourceTypeCode { get; set; }

		public virtual string ScormTypeCode { get; set; }

		public virtual string Identifier { get; set; }

		public virtual string Href { get; set; }
	}
}
