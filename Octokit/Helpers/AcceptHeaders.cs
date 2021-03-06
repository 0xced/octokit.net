﻿using System.Diagnostics.CodeAnalysis;

namespace Octokit
{
    public static class AcceptHeaders
    {
        public const string StableVersion = "application/vnd.github.v3";

        public const string StableVersionHtml = "application/vnd.github.html";

        public const string RedirectsPreviewThenStableVersionJson = "application/vnd.github.quicksilver-preview+json; charset=utf-8, application/vnd.github.v3+json; charset=utf-8";

        public const string CommitReferenceSha1MediaType = "application/vnd.github.v3.sha";

        public const string OrganizationPermissionsPreview = "application/vnd.github.ironman-preview+json";

        /// <summary>
        /// Support for retrieving information about open source license usage on GitHub.com.
        /// Custom media type: drax-preview Announced: 2015-03-09 Update 1: 2015-06-24 Update 2: 2015-08-04
        /// </summary>
        public const string LicensesApiPreview = "application/vnd.github.drax-preview+json";

        public const string ProtectedBranchesApiPreview = "application/vnd.github.loki-preview+json";

        public const string StarCreationTimestamps = "application/vnd.github.v3.star+json";

        public const string IssueLockingUnlockingApiPreview = "application/vnd.github.the-key-preview+json";

        public const string SquashCommitPreview = "application/vnd.github.polaris-preview+json";

        public const string MigrationsApiPreview = "application/vnd.github.wyandotte-preview+json";

        public const string ReactionsPreview = "application/vnd.github.squirrel-girl-preview";

        public const string SignatureVerificationPreview = "application/vnd.github.cryptographer-preview+sha";

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Gpg")]
        public const string GpgKeysPreview = "application/vnd.github.cryptographer-preview";

        public const string DeploymentApiPreview = "application/vnd.github.ant-man-preview+json";

        public const string InvitationsApiPreview = "application/vnd.github.swamp-thing-preview+json";

        public const string PagesApiPreview = "application/vnd.github.mister-fantastic-preview+json";

        public const string IssueTimelineApiPreview = "application/vnd.github.mockingbird-preview";

        public const string RepositoryTrafficApiPreview = "application/vnd.github.spiderman-preview";

        public const string PullRequestReviewsApiPreview = "application/vnd.github.black-cat-preview+json";

        public const string DraftPullRequestApiPreview = "application/vnd.github.shadow-cat-preview+json";

        public const string ProjectsApiPreview = "application/vnd.github.inertia-preview+json";

        public const string OrganizationMembershipPreview = "application/vnd.github.korra-preview+json";

        public const string NestedTeamsPreview = "application/vnd.github.hellcat-preview+json";

        public const string GitHubAppsPreview = "application/vnd.github.machine-man-preview+json";

        public const string PreReceiveEnvironmentsPreview = "application/vnd.github.eye-scream-preview+json";

        public const string LabelsApiPreview = "application/vnd.github.symmetra-preview+json";

        public const string RepositoryTransferPreview = "application/vnd.github.nightshade-preview+json";

        public const string ChecksApiPreview = "application/vnd.github.antiope-preview+json";

        public const string ProtectedBranchesRequiredApprovingApiPreview = "application/vnd.github.luke-cage-preview+json";

        public const string IssueEventsApiPreview = "application/vnd.github.starfox-preview";

        public const string DeploymentStatusesPreview = "application/vnd.github.flash-preview+json";

        /// <summary>
        /// Combines multiple preview headers. GitHub API supports Accept header with multiple
        /// values separated by comma.
        /// </summary>
        /// <param name="headers">Accept header values that will be combine to single Accept header.</param>
        /// <remarks>
        /// This Accept header <c>application/vnd.github.loki-preview+json,application/vnd.github.drax-preview+json</c>
        /// indicated we want both Protected Branches and Licenses preview APIs.
        /// </remarks>
        /// <returns>Accept header value.</returns>
        public static string Concat(params string[] headers)
        {
            return string.Join(",", headers);
        }
    }
}
