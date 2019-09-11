using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class ImsssSequencingRule {

		public virtual string Action { get; set; }

		public virtual int ImsssSequencingRuleId { get; set; }

		public virtual string ImsssSequencingId { get; set; }

		public virtual string RuleType { get; set; }

		public virtual string ConditionCombination { get; set; }
	}
}
