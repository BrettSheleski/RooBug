using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
	public partial class ImsssSequencingRollupRule {

		public virtual int ImsssSequencingRollupRuleId { get; set; }

		public virtual string ImsssSequencingRollupId { get; set; }

		public virtual string Action { get; set; }

		public virtual string ConditionCombination { get; set; }

		public virtual string ChildActivitySet { get; set; }

		public virtual int MinimumCount { get; set; }

		public virtual string MinimumPercent { get; set; }
	}
}
