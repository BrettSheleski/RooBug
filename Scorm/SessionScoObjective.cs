using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class SessionScoObjective {

		public virtual string SessionScoObjectiveId { get; set; }

		public virtual string SessionScoId { get; set; }

		public virtual string PackageObjectiveId { get; set; }

		public virtual string CompletionStatusCode { get; set; }

		public virtual string SuccessStatusCode { get; set; }

		public virtual string Description { get; set; }

		public virtual string ScoreScaled { get; set; }

		public virtual string ScoreRaw { get; set; }

		public virtual string ScoreMin { get; set; }

		public virtual string ScoreMax { get; set; }

		public virtual string Progress { get; set; }
	}
}
