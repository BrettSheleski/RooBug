using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class SessionSco {

		public virtual string SessionScoId { get; set; }

		public virtual string SessionId { get; set; }

		public virtual string ScormPackageScoId { get; set; }

		public virtual string CompletionStatusCode { get; set; }

		public virtual string SuccessStateCode { get; set; }

		public virtual string CreditTypeCode { get; set; }

		public virtual string ModeTypeCode { get; set; }

		public virtual string ProgressMeasure { get; set; }

		public virtual string ScaledPassingScore { get; set; }

		public virtual string ScoreScaled { get; set; }

		public virtual string ScoreRaw { get; set; }

		public virtual string ScoreMin { get; set; }

		public virtual string ScoreMax { get; set; }

		public virtual string SessionTimeSeconds { get; set; }

		public virtual string EntryTypeCode { get; set; }

		public virtual string ExitTypeCode { get; set; }

		public virtual string MaxTimeAllowedSeconds { get; set; }

		public virtual string TimeLimitActionTypeCode { get; set; }

		public virtual string TotalTimeSeconds { get; set; }

		public virtual string CompletionThreshold { get; set; }
	}
}
