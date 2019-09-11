using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class ImsssSequencingControlMode {

		public virtual string ImsssSequencingId { get; set; }

		public virtual string Choice { get; set; }

		public virtual string ChoiceExit { get; set; }

		public virtual string Flow { get; set; }

		public virtual string ForwardOnly { get; set; }

		public virtual string UseCurrentAttemptObjectiveInfo { get; set; }

		public virtual string UseCurrentAttemptProgressInfo { get; set; }
	}
}
