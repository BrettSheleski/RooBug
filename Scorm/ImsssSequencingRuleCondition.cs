using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class ImsssSequencingRuleCondition {

		public virtual int ImsssSequencingRuleConditionId { get; set; }

		public virtual int ImsssSequencingRuleId { get; set; }

		public virtual string Condition { get; set; }

		public virtual string ReferencedObjective { get; set; }

		public virtual string MeasureThreshold { get; set; }

		public virtual string Operator { get; set; }
	}
}
