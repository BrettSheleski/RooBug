using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Sheleski.Roobug.Scorm
{
    public class ModelEntityBuilders 
    {
        public static void BuildModelEntity(EntityTypeBuilder<CompletionStatus> builder)
        {
            builder.ToTable("completion_status");

            builder.Property(p => p.CompletionStatusCode).HasColumnName("completion_status_code").HasMaxLength(20).IsRequired();
            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(50).IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(20).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<CreditType> builder)
        {
            builder.ToTable("credit_type");

            builder.Property(p => p.CreditTypeCode).HasColumnName("credit_type_code").HasMaxLength(20).IsRequired();
            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(50).IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(20).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<EntryType> builder)
        {
            builder.ToTable("entry_type");

            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(50).IsRequired();
            builder.Property(p => p.EntryTypeCode).HasColumnName("entry_type_code").HasMaxLength(20).IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(20).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ExitType> builder)
        {
            builder.ToTable("exit_type");

            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(50).IsRequired();
            builder.Property(p => p.ExitTypeCode).HasColumnName("exit_type_code").HasMaxLength(20).IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(20).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencing> builder)
        {
            builder.ToTable("imsss_sequencing");

            builder.Property(p => p.ImsssSequencingId).HasColumnName("imsss_sequencing_id").IsRequired();
            builder.Property(p => p.ImsssSequencingIdref).HasColumnName("imsss_sequencing_idref").IsRequired();
            builder.Property(p => p.ScormPackageId).HasColumnName("scorm_package_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingControlMode> builder)
        {
            builder.ToTable("imsss_sequencing_control_mode");

            builder.Property(p => p.Choice).HasColumnName("choice").IsRequired();
            builder.Property(p => p.ChoiceExit).HasColumnName("choice_exit").IsRequired();
            builder.Property(p => p.Flow).HasColumnName("flow").IsRequired();
            builder.Property(p => p.ForwardOnly).HasColumnName("forward_only").IsRequired();
            builder.Property(p => p.ImsssSequencingId).HasColumnName("imsss_sequencing_id").IsRequired();
            builder.Property(p => p.UseCurrentAttemptObjectiveInfo).HasColumnName("use_current_attempt_objective_info").IsRequired();
            builder.Property(p => p.UseCurrentAttemptProgressInfo).HasColumnName("use_current_attempt_progress_info").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingDeliveryControl> builder)
        {
            builder.ToTable("imsss_sequencing_delivery_controls");

            builder.Property(p => p.CompletionSetByContent).HasColumnName("completion_set_by_content").IsRequired();
            builder.Property(p => p.ImsssSequencingId).HasColumnName("imsss_sequencing_id").IsRequired();
            builder.Property(p => p.ObjectiveSetByContent).HasColumnName("objective_set_by_content").IsRequired();
            builder.Property(p => p.Tracked).HasColumnName("tracked").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingLimitCondition> builder)
        {
            builder.ToTable("imsss_sequencing_limit_condition");

            builder.Property(p => p.ActivityAbsoluteDurationLimit).HasColumnName("activity_absolute_duration_limit").IsRequired();
            builder.Property(p => p.ActivityExperiencedDurationLimit).HasColumnName("activity_experienced_duration_limit").IsRequired();
            builder.Property(p => p.AttemptAbsoluteDurationLimit).HasColumnName("attempt_absolute_duration_limit").IsRequired();
            builder.Property(p => p.AttemptExperiencedDurationLimit).HasColumnName("attempt_experienced_duration_limit").IsRequired();
            builder.Property(p => p.AttemptLimit).HasColumnName("attempt_limit").IsRequired();
            builder.Property(p => p.BeginTimeLimit).HasColumnName("begin_time_limit").IsRequired();
            builder.Property(p => p.EndTimeLimit).HasColumnName("end_time_limit").IsRequired();
            builder.Property(p => p.ImsssSequencingId).HasColumnName("imsss_sequencing_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingObjective> builder)
        {
            builder.ToTable("imsss_sequencing_objective");

            builder.Property(p => p.ImsssSequencingId).HasColumnName("imsss_sequencing_id").IsRequired();
            builder.Property(p => p.ImsssSequencingObjectiveId).HasColumnName("imsss_sequencing_objective_id").IsRequired();
            builder.Property(p => p.IsPrimary).HasColumnName("is_primary").IsRequired();
            builder.Property(p => p.MinNormalizedMeasure).HasColumnName("min_normalized_measure").IsRequired();
            builder.Property(p => p.PackageObjectiveId).HasColumnName("package_objective_id").IsRequired();
            builder.Property(p => p.SatisfiedByMeasure).HasColumnName("satisfied_by_measure").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingObjectiveMapInfo> builder)
        {
            builder.ToTable("imsss_sequencing_objective_map_info");

            builder.Property(p => p.ImsssSequencingObjectiveId).HasColumnName("imsss_sequencing_objective_id").IsRequired();
            builder.Property(p => p.ImsssSequencingObjectiveMapInfoId).HasColumnName("imsss_sequencing_objective_map_info_id").IsRequired();
            builder.Property(p => p.ReadNormalizedMeasure).HasColumnName("read_normalized_measure").IsRequired();
            builder.Property(p => p.ReadSatisfiedStatus).HasColumnName("read_satisfied_status").IsRequired();
            builder.Property(p => p.TargetObjectiveId).HasColumnName("target_objective_id").HasMaxLength(100).IsRequired();
            builder.Property(p => p.WriteNormalizedMeasure).HasColumnName("write_normalized_measure").IsRequired();
            builder.Property(p => p.WriteSatisfiedStatus).HasColumnName("write_satisfied_status").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingOrigId> builder)
        {
            builder.ToTable("imsss_sequencing_orig_id");

            builder.Property(p => p.ImsssSequencingId).HasColumnName("imsss_sequencing_id").IsRequired();
            builder.Property(p => p.OrigId).HasColumnName("orig_id").HasMaxLength(100).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingPackageOrganization> builder)
        {
            builder.ToTable("imsss_sequencing_package_organization");

            builder.Property(p => p.ImsssSequencingId).HasColumnName("imsss_sequencing_id").IsRequired();
            builder.Property(p => p.ScormPackageOrganizationId).HasColumnName("scorm_package_organization_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingPackageOrganizationItem> builder)
        {
            builder.ToTable("imsss_sequencing_package_organization_item");

            builder.Property(p => p.ImsssSequencingId).HasColumnName("imsss_sequencing_id").IsRequired();
            builder.Property(p => p.ScormPackageOrganizationItemId).HasColumnName("scorm_package_organization_item_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingRandomizationControl> builder)
        {
            builder.ToTable("imsss_sequencing_randomization_controls");

            builder.Property(p => p.ImsssSequencingId).HasColumnName("imsss_sequencing_id").IsRequired();
            builder.Property(p => p.RandomizationTiming).HasColumnName("randomization_timing").HasMaxLength(50).IsRequired();
            builder.Property(p => p.ReorderChildren).HasColumnName("reorder_children").IsRequired();
            builder.Property(p => p.SelectCount).HasColumnName("select_count").IsRequired();
            builder.Property(p => p.SelectionTiming).HasColumnName("selection_timing").HasMaxLength(50).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingRollup> builder)
        {
            builder.ToTable("imsss_sequencing_rollup");

            builder.Property(p => p.ImsssSequencingId).HasColumnName("imsss_sequencing_id").IsRequired();
            builder.Property(p => p.ObjectiveMeasureWeight).HasColumnName("objective_measure_weight").IsRequired();
            builder.Property(p => p.RollupObjectiveSatisfied).HasColumnName("rollup_objective_satisfied").IsRequired();
            builder.Property(p => p.RollupProgressCompletion).HasColumnName("rollup_progress_completion").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingRollupRule> builder)
        {
            builder.ToTable("imsss_sequencing_rollup_rule");

            builder.Property(p => p.Action).HasColumnName("action").HasMaxLength(100).IsRequired();
            builder.Property(p => p.ChildActivitySet).HasColumnName("child_activity_set").HasMaxLength(50).IsRequired();
            builder.Property(p => p.ConditionCombination).HasColumnName("condition_combination").HasMaxLength(100).IsRequired();
            builder.Property(p => p.ImsssSequencingRollupId).HasColumnName("imsss_sequencing_rollup_id").IsRequired();
            builder.Property(p => p.ImsssSequencingRollupRuleId).HasColumnName("imsss_sequencing_rollup_rule_id").IsRequired();
            builder.Property(p => p.MinimumCount).HasColumnName("minimum_count").IsRequired();
            builder.Property(p => p.MinimumPercent).HasColumnName("minimum_percent").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingRollupRuleCondition> builder)
        {
            builder.ToTable("imsss_sequencing_rollup_rule_condition");

            builder.Property(p => p.Condition).HasColumnName("condition").HasMaxLength(100).IsRequired();
            builder.Property(p => p.ImsssSequencingRollupRuleConditionId).HasColumnName("imsss_sequencing_rollup_rule_condition_id").IsRequired();
            builder.Property(p => p.ImsssSequencingRollupRuleId).HasColumnName("imsss_sequencing_rollup_rule_id").IsRequired();
            builder.Property(p => p.Operator).HasColumnName("operator").HasMaxLength(10).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingRule> builder)
        {
            builder.ToTable("imsss_sequencing_rule");

            builder.Property(p => p.Action).HasColumnName("action").HasMaxLength(100).IsRequired();
            builder.Property(p => p.ConditionCombination).HasColumnName("condition_combination").HasMaxLength(10).IsRequired();
            builder.Property(p => p.ImsssSequencingId).HasColumnName("imsss_sequencing_id").IsRequired();
            builder.Property(p => p.ImsssSequencingRuleId).HasColumnName("imsss_sequencing_rule_id").IsRequired();
            builder.Property(p => p.RuleType).HasColumnName("rule_type").HasMaxLength(50).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ImsssSequencingRuleCondition> builder)
        {
            builder.ToTable("imsss_sequencing_rule_condition");

            builder.Property(p => p.Condition).HasColumnName("condition").HasMaxLength(100).IsRequired();
            builder.Property(p => p.ImsssSequencingRuleConditionId).HasColumnName("imsss_sequencing_rule_condition_id").IsRequired();
            builder.Property(p => p.ImsssSequencingRuleId).HasColumnName("imsss_sequencing_rule_id").IsRequired();
            builder.Property(p => p.MeasureThreshold).HasColumnName("measure_threshold").IsRequired();
            builder.Property(p => p.Operator).HasColumnName("operator").HasMaxLength(10).IsRequired();
            builder.Property(p => p.ReferencedObjective).HasColumnName("referenced_objective").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<InteractionResult> builder)
        {
            builder.ToTable("interaction_result");

            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(50).IsRequired();
            builder.Property(p => p.InteractionResultCode).HasColumnName("interaction_result_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(20).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<InteractionType> builder)
        {
            builder.ToTable("interaction_type");

            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(50).IsRequired();
            builder.Property(p => p.InteractionTypeCode).HasColumnName("interaction_type_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(20).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<Learner> builder)
        {
            builder.ToTable("learner");

            builder.Property(p => p.LearnerId).HasColumnName("learner_id").IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(250).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<LearnerPreference> builder)
        {
            builder.ToTable("learner_preference");

            builder.Property(p => p.AudioCaptioning).HasColumnName("audio_captioning").IsRequired();
            builder.Property(p => p.AudioLevel).HasColumnName("audio_level").IsRequired();
            builder.Property(p => p.DeliverySpeed).HasColumnName("delivery_speed").IsRequired();
            builder.Property(p => p.Language).HasColumnName("language").HasMaxLength(250).IsRequired();
            builder.Property(p => p.LearnerId).HasColumnName("learner_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ModeType> builder)
        {
            builder.ToTable("mode_type");

            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(50).IsRequired();
            builder.Property(p => p.ModeTypeCode).HasColumnName("mode_type_code").HasMaxLength(20).IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(20).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<Package> builder)
        {
            builder.ToTable("package");

            builder.Property(p => p.Identifier).HasColumnName("identifier").HasMaxLength(250).IsRequired();
            builder.Property(p => p.Path).HasColumnName("path").HasMaxLength(250).IsRequired();
            builder.Property(p => p.ScormPackageId).HasColumnName("scorm_package_id").IsRequired();
            builder.Property(p => p.ScormVersionCode).HasColumnName("scorm_version_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.Version).HasColumnName("version").HasMaxLength(20).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<PackageConfiguration> builder)
        {
            builder.ToTable("package_configuration");

            builder.Property(p => p.AttemptLimit).HasColumnName("attempt_limit").IsRequired();
            builder.Property(p => p.CompletionThreshold).HasColumnName("completion_threshold").IsRequired();
            builder.Property(p => p.Credit).HasColumnName("credit").IsRequired();
            builder.Property(p => p.IsPreviewEnabled).HasColumnName("is_preview_enabled").IsRequired();
            builder.Property(p => p.IsResumeEnabled).HasColumnName("is_resume_enabled").IsRequired();
            builder.Property(p => p.IsReviewEnabled).HasColumnName("is_review_enabled").IsRequired();
            builder.Property(p => p.MaxTimeAllowedSeconds).HasColumnName("max_time_allowed_seconds").IsRequired();
            builder.Property(p => p.PackageConfigurationId).HasColumnName("package_configuration_id").IsRequired();
            builder.Property(p => p.PackageId).HasColumnName("package_id").IsRequired();
            builder.Property(p => p.ScaledPassingScore).HasColumnName("scaled_passing_score").IsRequired();
            builder.Property(p => p.TimeLimitActionTypeCode).HasColumnName("time_limit_action_type_code").HasMaxLength(20).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<PackageLaunchData> builder)
        {
            builder.ToTable("package_launch_data");

            builder.Property(p => p.LaunchData).HasColumnName("launch_data").HasMaxLength(-1).IsRequired();
            builder.Property(p => p.ScormPackageId).HasColumnName("scorm_package_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<PackageObjective> builder)
        {
            builder.ToTable("package_objective");

            builder.Property(p => p.Id).HasColumnName("id").HasMaxLength(-1).IsRequired();
            builder.Property(p => p.PackageObjectiveId).HasColumnName("package_objective_id").IsRequired();
            builder.Property(p => p.ScormPackageId).HasColumnName("scorm_package_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<PackageOrganization> builder)
        {
            builder.ToTable("package_organization");

            builder.Property(p => p.Identifier).HasColumnName("identifier").HasMaxLength(250).IsRequired();
            builder.Property(p => p.IsDefault).HasColumnName("is_default").IsRequired();
            builder.Property(p => p.ScormPackageId).HasColumnName("scorm_package_id").IsRequired();
            builder.Property(p => p.ScormPackageOrganizationId).HasColumnName("scorm_package_organization_id").IsRequired();
            builder.Property(p => p.Title).HasColumnName("title").HasMaxLength(500).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<PackageOrganizationItem> builder)
        {
            builder.ToTable("package_organization_item");

            builder.Property(p => p.Identifier).HasColumnName("identifier").HasMaxLength(250).IsRequired();
            builder.Property(p => p.IdentifierRef).HasColumnName("identifier_ref").HasMaxLength(250).IsRequired();
            builder.Property(p => p.ParentItemId).HasColumnName("parent_item_id").IsRequired();
            builder.Property(p => p.ScormPackageOrganizationId).HasColumnName("scorm_package_organization_id").IsRequired();
            builder.Property(p => p.ScormPackageOrganizationItemId).HasColumnName("scorm_package_organization_item_id").IsRequired();
            builder.Property(p => p.Title).HasColumnName("title").HasMaxLength(500).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<PackageOrganizationItemResource> builder)
        {
            builder.ToTable("package_organization_item_resource");

            builder.Property(p => p.PackageOrganizationItemId).HasColumnName("package_organization_item_id").IsRequired();
            builder.Property(p => p.PackageResourceId).HasColumnName("package_resource_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<PackageResource> builder)
        {
            builder.ToTable("package_resource");

            builder.Property(p => p.Href).HasColumnName("href").HasMaxLength(250).IsRequired();
            builder.Property(p => p.Identifier).HasColumnName("identifier").HasMaxLength(250).IsRequired();
            builder.Property(p => p.ScormPackageId).HasColumnName("scorm_package_id").IsRequired();
            builder.Property(p => p.ScormPackageResourceId).HasColumnName("scorm_package_resource_id").IsRequired();
            builder.Property(p => p.ScormPackageResourceTypeCode).HasColumnName("scorm_package_resource_type_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.ScormTypeCode).HasColumnName("scorm_type_code").HasMaxLength(10).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<PackageResourceDependency> builder)
        {
            builder.ToTable("package_resource_dependency");

            builder.Property(p => p.DependencyScormPackageResourceId).HasColumnName("dependency_scorm_package_resource_id").IsRequired();
            builder.Property(p => p.ScormPackageResourceId).HasColumnName("scorm_package_resource_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<PackageResourceFile> builder)
        {
            builder.ToTable("package_resource_file");

            builder.Property(p => p.Href).HasColumnName("href").HasMaxLength(250).IsRequired();
            builder.Property(p => p.ScormPackageResourceFileId).HasColumnName("scorm_package_resource_file_id").IsRequired();
            builder.Property(p => p.ScormPackageResourceId).HasColumnName("scorm_package_resource_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<PackageResourceType> builder)
        {
            builder.ToTable("package_resource_type");

            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(50).IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(10).IsRequired();
            builder.Property(p => p.ScormPackageResourceTypeCode).HasColumnName("scorm_package_resource_type_code").HasMaxLength(10).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<ScormType> builder)
        {
            builder.ToTable("scorm_type");

            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(50).IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(50).IsRequired();
            builder.Property(p => p.ScormTypeCode).HasColumnName("scorm_type_code").HasMaxLength(10).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable("session");

            builder.Property(p => p.DateUtc).HasColumnName("date_utc").IsRequired();
            builder.Property(p => p.LearnerId).HasColumnName("learner_id").IsRequired();
            builder.Property(p => p.PackageConfigurationId).HasColumnName("package_configuration_id").IsRequired();
            builder.Property(p => p.SessionId).HasColumnName("session_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<SessionSco> builder)
        {
            builder.ToTable("session_sco");

            builder.Property(p => p.CompletionStatusCode).HasColumnName("completion_status_code").HasMaxLength(20).IsRequired();
            builder.Property(p => p.CompletionThreshold).HasColumnName("completion_threshold").IsRequired();
            builder.Property(p => p.CreditTypeCode).HasColumnName("credit_type_code").HasMaxLength(20).IsRequired();
            builder.Property(p => p.EntryTypeCode).HasColumnName("entry_type_code").HasMaxLength(20).IsRequired();
            builder.Property(p => p.ExitTypeCode).HasColumnName("exit_type_code").HasMaxLength(20).IsRequired();
            builder.Property(p => p.MaxTimeAllowedSeconds).HasColumnName("max_time_allowed_seconds").IsRequired();
            builder.Property(p => p.ModeTypeCode).HasColumnName("mode_type_code").HasMaxLength(20).IsRequired();
            builder.Property(p => p.ProgressMeasure).HasColumnName("progress_measure").IsRequired();
            builder.Property(p => p.ScaledPassingScore).HasColumnName("scaled_passing_score").IsRequired();
            builder.Property(p => p.ScoreMax).HasColumnName("score_max").IsRequired();
            builder.Property(p => p.ScoreMin).HasColumnName("score_min").IsRequired();
            builder.Property(p => p.ScoreRaw).HasColumnName("score_raw").IsRequired();
            builder.Property(p => p.ScoreScaled).HasColumnName("score_scaled").IsRequired();
            builder.Property(p => p.ScormPackageScoId).HasColumnName("scorm_package_sco_id").IsRequired();
            builder.Property(p => p.SessionId).HasColumnName("session_id").IsRequired();
            builder.Property(p => p.SessionScoId).HasColumnName("session_sco_id").IsRequired();
            builder.Property(p => p.SessionTimeSeconds).HasColumnName("session_time_seconds").IsRequired();
            builder.Property(p => p.SuccessStateCode).HasColumnName("success_state_code").HasMaxLength(20).IsRequired();
            builder.Property(p => p.TimeLimitActionTypeCode).HasColumnName("time_limit_action_type_code").HasMaxLength(20).IsRequired();
            builder.Property(p => p.TotalTimeSeconds).HasColumnName("total_time_seconds").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<SessionScoInteraction> builder)
        {
            builder.ToTable("session_sco_interaction");

            builder.Property(p => p.DateUtc).HasColumnName("date_utc").IsRequired();
            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(250).IsRequired();
            builder.Property(p => p.InteractionResultCode).HasColumnName("interaction_result_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.InteractionTypeCode).HasColumnName("interaction_type_code").HasMaxLength(10).IsRequired();
            builder.Property(p => p.LatencySeconds).HasColumnName("latency_seconds").IsRequired();
            builder.Property(p => p.SessionScoId).HasColumnName("session_sco_id").IsRequired();
            builder.Property(p => p.SessionScoInteractionId).HasColumnName("session_sco_interaction_id").IsRequired();
            builder.Property(p => p.SortOrder).HasColumnName("sort_order").IsRequired();
            builder.Property(p => p.Weighting).HasColumnName("weighting").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<SessionScoInteractionCorrectResponse> builder)
        {
            builder.ToTable("session_sco_interaction_correct_response");

            builder.Property(p => p.Response).HasColumnName("response").HasMaxLength(-1).IsRequired();
            builder.Property(p => p.SessionScoInteractionCorrectResponseId).HasColumnName("session_sco_interaction_correct_response_id").IsRequired();
            builder.Property(p => p.SessionScoInteractionId).HasColumnName("session_sco_interaction_id").IsRequired();
            builder.Property(p => p.SortOrder).HasColumnName("sort_order").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<SessionScoInteractionId> builder)
        {
            builder.ToTable("session_sco_interaction_id");

            builder.Property(p => p.Id).HasColumnName("id").HasMaxLength(-1).IsRequired();
            builder.Property(p => p.Identifier).HasColumnName("session_sco_interaction_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<SessionScoInteractionLearnerResponse> builder)
        {
            builder.ToTable("session_sco_interaction_learner_response");

            builder.Property(p => p.Response).HasColumnName("response").HasMaxLength(-1).IsRequired();
            builder.Property(p => p.SessionScoInteractionId).HasColumnName("session_sco_interaction_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<SessionScoInteractionObjective> builder)
        {
            builder.ToTable("session_sco_interaction_objective");

            builder.Property(p => p.SessionScoInteractionId).HasColumnName("session_sco_interaction_id").IsRequired();
            builder.Property(p => p.SessionScoObjectiveId).HasColumnName("session_sco_objective_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<SessionScoLaunchData> builder)
        {
            builder.ToTable("session_sco_launch_data");

            builder.Property(p => p.LaunchData).HasColumnName("launch_data").HasMaxLength(-1).IsRequired();
            builder.Property(p => p.SessionScoId).HasColumnName("session_sco_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<SessionScoLearnerComment> builder)
        {
            builder.ToTable("session_sco_learner_comment");

            builder.Property(p => p.Comment).HasColumnName("comment").HasMaxLength(-1).IsRequired();
            builder.Property(p => p.Location).HasColumnName("location").HasMaxLength(250).IsRequired();
            builder.Property(p => p.SessionScoId).HasColumnName("session_sco_id").IsRequired();
            builder.Property(p => p.SessionScoLearnerCommentId).HasColumnName("session_sco_learner_comment_id").IsRequired();
            builder.Property(p => p.SortOrder).HasColumnName("sort_order").IsRequired();
            builder.Property(p => p.TimestampUtc).HasColumnName("timestamp_utc").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<SessionScoLmsComment> builder)
        {
            builder.ToTable("session_sco_lms_comment");

            builder.Property(p => p.Comment).HasColumnName("comment").HasMaxLength(-1).IsRequired();
            builder.Property(p => p.Location).HasColumnName("location").HasMaxLength(250).IsRequired();
            builder.Property(p => p.SessionScoId).HasColumnName("session_sco_id").IsRequired();
            builder.Property(p => p.SessionScoLmsCommentId).HasColumnName("session_sco_lms_comment_id").IsRequired();
            builder.Property(p => p.SortOrder).HasColumnName("sort_order").IsRequired();
            builder.Property(p => p.TimestampUtc).HasColumnName("timestamp_utc").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<SessionScoLocation> builder)
        {
            builder.ToTable("session_sco_location");

            builder.Property(p => p.Location).HasColumnName("location").HasMaxLength(-1).IsRequired();
            builder.Property(p => p.SessionScoId).HasColumnName("session_sco_id").IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<SessionScoObjective> builder)
        {
            builder.ToTable("session_sco_objective");

            builder.Property(p => p.CompletionStatusCode).HasColumnName("completion_status_code").HasMaxLength(20).IsRequired();
            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(250).IsRequired();
            builder.Property(p => p.PackageObjectiveId).HasColumnName("package_objective_id").IsRequired();
            builder.Property(p => p.Progress).HasColumnName("progress").IsRequired();
            builder.Property(p => p.ScoreMax).HasColumnName("score_max").IsRequired();
            builder.Property(p => p.ScoreMin).HasColumnName("score_min").IsRequired();
            builder.Property(p => p.ScoreRaw).HasColumnName("score_raw").IsRequired();
            builder.Property(p => p.ScoreScaled).HasColumnName("score_scaled").IsRequired();
            builder.Property(p => p.SessionScoId).HasColumnName("session_sco_id").IsRequired();
            builder.Property(p => p.SessionScoObjectiveId).HasColumnName("session_sco_objective_id").IsRequired();
            builder.Property(p => p.SuccessStatusCode).HasColumnName("success_status_code").HasMaxLength(20).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<SessionScoSuspendData> builder)
        {
            builder.ToTable("session_sco_suspend_data");

            builder.Property(p => p.SessionScoId).HasColumnName("session_sco_id").IsRequired();
            builder.Property(p => p.SuspendData).HasColumnName("suspend_data").HasMaxLength(-1).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<SuccessStatus> builder)
        {
            builder.ToTable("success_status");

            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(50).IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(20).IsRequired();
            builder.Property(p => p.SuccessStatusCode).HasColumnName("success_status_code").HasMaxLength(20).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<TimeLimitActionType> builder)
        {
            builder.ToTable("time_limit_action_type");

            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(50).IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(50).IsRequired();
            builder.Property(p => p.TimeLimitActionTypeCode).HasColumnName("time_limit_action_type_code").HasMaxLength(20).IsRequired();

        }

        public static void BuildModelEntity(EntityTypeBuilder<Version> builder)
        {
            builder.ToTable("version");

            builder.Property(p => p.SchemaName).HasColumnName("schema_name").HasMaxLength(10).IsRequired();
            builder.Property(p => p.SchemaVersion).HasColumnName("schema_version").HasMaxLength(25).IsRequired();
            builder.Property(p => p.ScormVersionCode).HasColumnName("scorm_version_code").HasMaxLength(10).IsRequired();

        }

    }
}
