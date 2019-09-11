using Microsoft.EntityFrameworkCore;
using System;

namespace Sheleski.Roobug.Scorm
{
    public static class ModelBuilderExtensions
    {
        public static void UseScorm(this ModelBuilder modelBuilder)
        {
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<CompletionStatus>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<CreditType>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<EntryType>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ExitType>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencing>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingControlMode>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingDeliveryControl>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingLimitCondition>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingObjective>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingObjectiveMapInfo>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingOrigId>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingPackageOrganization>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingPackageOrganizationItem>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingRandomizationControl>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingRollup>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingRollupRule>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingRollupRuleCondition>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingRule>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ImsssSequencingRuleCondition>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<InteractionResult>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<InteractionType>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<Learner>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<LearnerPreference>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ModeType>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<Package>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<PackageConfiguration>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<PackageLaunchData>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<PackageObjective>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<PackageOrganization>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<PackageOrganizationItem>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<PackageOrganizationItemResource>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<PackageResource>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<PackageResourceDependency>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<PackageResourceFile>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<PackageResourceType>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<ScormType>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<Session>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<SessionSco>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<SessionScoInteraction>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<SessionScoInteractionCorrectResponse>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<SessionScoInteractionId>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<SessionScoInteractionLearnerResponse>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<SessionScoInteractionObjective>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<SessionScoLaunchData>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<SessionScoLearnerComment>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<SessionScoLmsComment>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<SessionScoLocation>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<SessionScoObjective>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<SessionScoSuspendData>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<SuccessStatus>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<TimeLimitActionType>());
            ModelEntityBuilders.BuildModelEntity(modelBuilder.Entity<Version>());
        }
    }
}
