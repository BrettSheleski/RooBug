using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class PackageConfiguration {

		public virtual string PackageConfigurationId { get; set; }

		public virtual string PackageId { get; set; }

		public virtual string Credit { get; set; }

		public virtual string CompletionThreshold { get; set; }

		public virtual string IsReviewEnabled { get; set; }

		public virtual string IsPreviewEnabled { get; set; }

		public virtual string IsResumeEnabled { get; set; }

		public virtual string TimeLimitActionTypeCode { get; set; }

		public virtual int AttemptLimit { get; set; }

		public virtual string ScaledPassingScore { get; set; }

		public virtual string MaxTimeAllowedSeconds { get; set; }
	}
}
