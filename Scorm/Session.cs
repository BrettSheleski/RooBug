using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class Session {

		public virtual string SessionId { get; set; }

		public virtual string PackageConfigurationId { get; set; }

		public virtual string LearnerId { get; set; }

		public virtual DateTime DateUtc { get; set; }
	}
}
