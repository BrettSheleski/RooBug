using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class SessionScoInteraction {

		public virtual string SessionScoInteractionId { get; set; }

		public virtual string SessionScoId { get; set; }

		public virtual string InteractionTypeCode { get; set; }

		public virtual int SortOrder { get; set; }

		public virtual string InteractionResultCode { get; set; }

		public virtual DateTime DateUtc { get; set; }

		public virtual string Weighting { get; set; }

		public virtual string LatencySeconds { get; set; }

		public virtual string Description { get; set; }
	}
}
