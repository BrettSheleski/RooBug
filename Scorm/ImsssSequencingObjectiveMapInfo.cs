using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class ImsssSequencingObjectiveMapInfo {

		public virtual int ImsssSequencingObjectiveMapInfoId { get; set; }

		public virtual int ImsssSequencingObjectiveId { get; set; }

		public virtual string TargetObjectiveId { get; set; }

		public virtual string ReadSatisfiedStatus { get; set; }

		public virtual string ReadNormalizedMeasure { get; set; }

		public virtual string WriteSatisfiedStatus { get; set; }

		public virtual string WriteNormalizedMeasure { get; set; }
	}
}
