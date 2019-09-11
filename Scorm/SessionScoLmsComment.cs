using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class SessionScoLmsComment {

		public virtual string SessionScoLmsCommentId { get; set; }

		public virtual string SessionScoId { get; set; }

		public virtual int SortOrder { get; set; }

		public virtual DateTime TimestampUtc { get; set; }

		public virtual string Comment { get; set; }

		public virtual string Location { get; set; }
	}
}
