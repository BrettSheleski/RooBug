using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class Package {

		public virtual string ScormPackageId { get; set; }

		public virtual string ScormVersionCode { get; set; }

		public virtual string Identifier { get; set; }

		public virtual string Version { get; set; }

		public virtual string Path { get; set; }
	}
}
