using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class PackageResourceDependency {

		public virtual string ScormPackageResourceId { get; set; }

		public virtual string DependencyScormPackageResourceId { get; set; }
	}
}
