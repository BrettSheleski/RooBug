using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class LearnerPreference {

		public virtual string LearnerId { get; set; }

		public virtual string AudioLevel { get; set; }

		public virtual string Language { get; set; }

		public virtual string DeliverySpeed { get; set; }

		public virtual string AudioCaptioning { get; set; }
	}
}
