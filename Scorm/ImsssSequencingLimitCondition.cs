using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class ImsssSequencingLimitCondition {

		public virtual string ImsssSequencingId { get; set; }

		public virtual int AttemptLimit { get; set; }

		public virtual string AttemptAbsoluteDurationLimit { get; set; }

		public virtual string AttemptExperiencedDurationLimit { get; set; }

		public virtual string ActivityAbsoluteDurationLimit { get; set; }

		public virtual string ActivityExperiencedDurationLimit { get; set; }

		public virtual string BeginTimeLimit { get; set; }

		public virtual string EndTimeLimit { get; set; }
	}
}
