using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class SessionScoLearnerComment {

		public virtual string SessionScoLearnerCommentId { get; set; }

		public virtual string SessionScoId { get; set; }

		public virtual int SortOrder { get; set; }

		public virtual DateTime TimestampUtc { get; set; }

		public virtual string Comment { get; set; }

		public virtual string Location { get; set; }
	}
}
