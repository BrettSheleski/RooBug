using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class ImsssSequencingRollupRuleCondition {

		public virtual int ImsssSequencingRollupRuleConditionId { get; set; }

		public virtual int ImsssSequencingRollupRuleId { get; set; }

		public virtual string Condition { get; set; }

		public virtual string Operator { get; set; }
	}
}
