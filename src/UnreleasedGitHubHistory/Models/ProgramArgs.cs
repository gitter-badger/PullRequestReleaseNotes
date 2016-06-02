using System;
using System.Collections.Generic;
using LibGit2Sharp;
using PowerArgs;
using UnreleasedGitHubHistory.Providers;
using YamlDotNet.Serialization;

namespace UnreleasedGitHubHistory.Models
{
    public class ProgramArgs
    {
        [ArgShortcut("-rnsl")]
        [YamlMember(Alias = "release-note-sections")]
        [ArgExample("'Section1=Description For Section1,Section2=Description For Section2'", "Dictionary of GitHub Pull Request Labels and their descriptions which will be used for release note sections")]
        public List<string> ReleaseNoteSections { get; set; }

        [ArgShortcut("-rnsd")]
        [YamlMember(Alias = "release-note-sectionless-description")]
        public string ReleaseNoteSectionlessDescription { get; set; }

        [ArgShortcut("-rnud")]
        [YamlMember(Alias = "release-note-uncategorised-description")]
        public string ReleaseNoteUncategorisedDescription { get; set; }

        [ArgShortcut("-rns")]
        [YamlMember(Alias = "release-note-sectioned")]
        public bool? ReleaseNoteSectioned { get; set; }

        [ArgShortcut("-rnc")]
        [YamlMember(Alias = "release-note-categorised")]
        public bool? ReleaseNoteCategorised { get; set; }

        [ArgShortcut("-rncl")]
        [YamlMember(Alias = "release-note-categories")]
        [ArgExample("'Category1=Description For Category1,Category2=Description For Category2'", "Dictionary of GitHub Pull Request Labels and their descriptions which will be used for release note categorisation")]
        public List<string> ReleaseNoteCategories { get; set; }

        [ArgShortcut("-rncp")]
        [YamlMember(Alias = "release-note-category-prefix")]
        public string ReleaseNoteCategoryPrefix { get; set; }

        [ArgShortcut("-rnoa")]
        [YamlMember(Alias = "release-note-order-ascending")]
        public bool? ReleaseNoteOrderAscending { get; set; }

        [ArgShortcut("-rnow")]
        [YamlMember(Alias = "release-note-order-when")]
        public string ReleaseNoteOrderWhen { get; set; }

        [ArgShortcut("-rnqc")]
        [YamlMember(Alias = "release-note-quality-control-labels")]
        [ArgExample("Label1,Label2", "List of labels which a pull request without will be marked as up code to highlight items in release notes that haven't gone through quality control.")]
        public List<string> ReleaseNoteQualityControlLabels { get; set; }

        [ArgShortcut("-ghb")]
        [YamlMember(Alias = "git-branch-ref")]
        [ArgExample("refs/heads/master", "Git head branch reference")]
        public string ReleaseBranchRef { get; set; }

        [ArgShortcut("-grp")]
        [YamlMember(Alias = "git-repo-path")]
        [ArgExample(@"D:\Dev\Repo", "Local Git repository path")]
        public string GitRepositoryPath { get; set; }

        [ArgShortcut("-gta")]
        [YamlMember(Alias = "git-tags-annotated")]
        public bool GitTagsAnnotated { get; set; }

        [ArgShortcut("-ptc")]
        [YamlMember(Alias = "confluence-publish")]
        public bool PublishToConfluence { get; set; }

        [ArgExample("1223543", "Reference to Confluence release page parent ID")]
        [ArgShortcut("-cpp")]
        [YamlMember(Alias = "confluence-release-parent-page-id")]
        public string ConfluenceReleaseParentPageId { get; set; }

        [ArgExample("ABC", "Confluence space key")]
        [ArgShortcut("-csk")]
        [YamlMember(Alias = "confluence-space-key")]
        public string ConfluenceSpaceKey { get; set; }

        [ArgExample("johndoe", "Confluence username under which the page will be published")]
        [ArgShortcut("-cu")]
        [YamlMember(Alias = "confluence-username")]
        public string ConfluenceUser { get; set; }

        [ArgExample("******", "Confluence user password under which the page will be published")]
        [ArgShortcut("-cp")]
        [YamlMember(Alias = "confluence-password")]
        public string ConfluencePassword { get; set; }

        [ArgShortcut("-v")]
        [YamlMember(Alias = "verbose")]
        public bool VerboseOutput { get; set; }

        [ArgShortcut("-aic")]
        [YamlMember(Alias = "accept-invalid-certificates")]
        public bool AcceptInvalidCertificates { get; set; }

        [ArgShortcut("-ptf")]
        [YamlMember(Alias = "file-publish")]
        public bool PublishToFile { get; set; }

        [ArgShortcut("-o")]
        [YamlMember(Alias = "file-name")]
        public string OutputFileName { get; set; }

        [ArgShortcut("-cau")]
        [YamlMember(Alias = "confluence-api-url")]
        public Uri ConfluenceApiUrl { get; set; }

        [ArgShortcut("-gr")]
        [YamlMember(Alias = "git-remote-name")]
        public string GitRemote { get; set; }

        [ArgShortcut("-el")]
        [YamlMember(Alias = "release-note-exclude")]
        public string ExcludeLabel { get; set; }

        [ArgShortcut("-fl")]
        [YamlMember(Alias = "release-note-follow")]
        public string FollowLabel { get; set; }

        [ArgShortcut("-gv")]
        [YamlMember(Alias = "git-version")]
        public string GitVersion { get; set; }

        [ArgShortcut("-rndf")]
        [YamlMember(Alias = "release-note-date-format")]
        public string ReleaseNoteDateFormat { get; set; }

        [ArgShortcut("-rnf")]
        [YamlMember(Alias = "release-note-format")]
        public string ReleaseNoteFormat { get; set; }

        [ArgShortcut("-rbho")]
        [YamlMember(Alias = "release-branch-heads-only")]
        public bool? ReleaseBranchHeadsOnly { get; set; }

        [ArgShortcut("-init")]
        public bool InitConfig { get; set; }

        [ArgShortcut("-prpn")]
        [YamlMember(Alias = "pull-request-provider-name")]
        [ArgExample("github", "Pull request provider name")]
        public string PullRequestProviderName { get; set; }

        [ArgShortcut("-ghau")]
        [YamlMember(Alias = "github-api-url")]
        public string GitHubApiUrl { get; set; }

        [ArgShortcut("-ghpt")]
        [YamlMember(Alias = "github-token")]
        [ArgExample("30aee2825c48560da50732c4f849bfbfd24c091e", "GitHub Personal Token")]
        public string GitHubToken { get; set; }

        [ArgShortcut("-gho")]
        [YamlMember(Alias = "github-owner")]
        [ArgExample("company", "GitHub Organisational Account")]
        public string GitHubOwner { get; set; }

        [ArgShortcut("-ghr")]
        [YamlMember(Alias = "github-repo")]
        [ArgExample("repo", "GitHub Repository Name")]
        public string GitHubRepository { get; set; }

        [ArgShortcut("-glpt")]
        [YamlMember(Alias = "gitlab-token")]
        [ArgExample("pjiS4SArhyHHypsRgXQW", "GitLab Personal Token")]
        public string GitLabToken { get; set; }

        [ArgShortcut("-glo")]
        [YamlMember(Alias = "gitlab-owner")]
        [ArgExample("company", "GitLab Organisational Account")]
        public string GitLabOwner { get; set; }

        [ArgShortcut("-glr")]
        [YamlMember(Alias = "gitlab-repo")]
        [ArgExample("repo", "GitLab Repository Name")]
        public string GitLabRepository { get; set; }

        [ArgShortcut("-glau")]
        [YamlMember(Alias="gitlab-api-url")]
        public string GitLabApiUrl { get; set; }

        [ArgShortcut("-glpi")]
        [YamlMember(Alias = "gitlab-project-id")]
        public string GitLabProjectId { get; set; }

        [ArgShortcut("-tau")]
        [YamlMember(Alias = "tfs-api-url")]
        public string TfsApiUrl { get; set; }

        [ArgShortcut("-tc")]
        [YamlMember(Alias = "tfs-collection")]
        public string TfsCollection { get; set; }

        [ArgShortcut("-tr")]
        [YamlMember(Alias = "tfs-repository")]
        public string TfsRepository { get; set; }

        [ArgShortcut("-tu")]
        [YamlMember(Alias = "tfs-username")]
        public string TfsUsername { get; set; }

        [ArgShortcut("-tpt")]
        [YamlMember(Alias = "tfs-token")]
        public string TfsToken { get; set; }

        [ArgIgnore]
        public Repository LocalGitRepository { get; set; }

        [ArgIgnore]
        public IPullRequestProvider PullRequestProvider { get; set; }

        public bool HeadBranchRestrictionApplies()
        {
            return ReleaseBranchHeadsOnly != null && (ReleaseBranchHeadsOnly.Value && !ReleaseBranchRef.CaseInsensitiveContains("refs/heads"));
        }
    }
}
