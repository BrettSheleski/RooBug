using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class ImsssSequencingObjective {

		public virtual int ImsssSequencingObjectiveId { get; set; }

		public virtual string ImsssSequencingId { get; set; }

		public virtual string PackageObjectiveId { get; set; }

		public virtual string IsPrimary { get; set; }

		public virtual string SatisfiedByMeasure { get; set; }

		public virtual string MinNormalizedMeasure { get; set; }
	}
}
