using System;
using System.Linq;

using Octokit;
using Semver;
using System.Threading.Tasks;

namespace GitHubUpdate
{
    public enum UpdateType
    {
        None,
        Major,
        Minor,
        Patch
    }

    public class UpdateChecker
    {
        readonly IReleasesClient releaseClient;
        internal readonly GitHubClient github;

        internal SemVersion currentVersion;
        internal string repositoryOwner;
        internal string repostoryName;
        internal Release latestRelease;

        public UpdateChecker(string owner, string name, string version)
        {
            Helper.ArgumentNotNullOrEmptyString(owner, "owner");
            Helper.ArgumentNotNullOrEmptyString(name, "name");

            github = new GitHubClient(new ProductHeaderValue(name + "-UpdateCheck"));
            releaseClient = github.Release;

            repositoryOwner = owner;
            repostoryName = name;
            this.currentVersion = Helper.StripInitialV(version);
        }

        public async Task<UpdateType> CheckUpdate()
        {
            var releases = await releaseClient.GetAll(repositoryOwner, repostoryName);
            latestRelease = releases.FirstOrDefault(release => Helper.StripInitialV(release.TagName) >= currentVersion);

            UpdateType type = UpdateType.None;
            string tagName = null, body = null;
            if (latestRelease != null)
            {
                tagName = latestRelease.TagName;
                body = latestRelease.Body;

                var latestVersion = Helper.StripInitialV(tagName);
                if (latestVersion.Major != currentVersion.Major)
                    type = UpdateType.Major;
                else if (latestVersion.Minor != currentVersion.Minor)
                    type = UpdateType.Minor;
                else if (latestVersion.Patch != currentVersion.Patch)
                    type = UpdateType.Patch;
            }

            return type;
        }

        public async Task<string> RenderReleaseNotes()
        {
            if (latestRelease == null)
                throw new InvalidOperationException();

            return await github.Miscellaneous.RenderRawMarkdown(latestRelease.Body);
        }

        public async void DownloadAsset(string assetname)
        {
            var assets = await releaseClient.GetAssets(repositoryOwner, repostoryName, latestRelease.Id);
            var asset = assets.First(n => n.Name == assetname);

            // asset.Url is some api wizardry that we'll maybe use later
            // for now, do some ugly shit
            const string template = "https://github.com/{0}/{1}/releases/download/{2}/{3}";
            string url = string.Format(template, repositoryOwner, repostoryName, latestRelease.TagName, assetname);

            System.Diagnostics.Process.Start(url);
        }
    }
}
