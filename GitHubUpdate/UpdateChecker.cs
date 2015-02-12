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
        private IReleasesClient _releaseClient;
        internal GitHubClient Github;

        internal SemVersion CurrentVersion;
        internal string RepositoryOwner;
        internal string RepostoryName;
        internal Release LatestRelease;

        void Init(string owner, string name, SemVersion version)
        {
            Github = new GitHubClient(new ProductHeaderValue(name + @"-UpdateCheck"));
            _releaseClient = Github.Release;

            RepositoryOwner = owner;
            RepostoryName = name;
            CurrentVersion = version;
        }

        public UpdateChecker(string owner, string name)
        {
            Helper.ArgumentNotNullOrEmptyString(owner, @"owner");
            Helper.ArgumentNotNullOrEmptyString(name, @"name");

            string version = System.Windows.Forms.Application.ProductVersion;

            version = version.Substring(0, version.LastIndexOf('.'));

            Init(owner, name, version);
        }

        public UpdateChecker(string owner, string name, string version)
        {
            Helper.ArgumentNotNullOrEmptyString(owner, @"owner");
            Helper.ArgumentNotNullOrEmptyString(name, @"name");
            Helper.ArgumentNotNullOrEmptyString(version, @"version");

            Init(owner, name, Helper.StripInitialV(version));
        }

        public async Task<UpdateType> CheckUpdate()
        {
            var releases = await _releaseClient.GetAll(RepositoryOwner, RepostoryName);
            LatestRelease = releases.FirstOrDefault(release => !release.Prerelease && Helper.StripInitialV(release.TagName) > CurrentVersion);

            if (LatestRelease == null) return UpdateType.None;

            var tagName = LatestRelease.TagName;
            var latestVersion = Helper.StripInitialV(tagName);

            if (latestVersion.Major != CurrentVersion.Major)
                return UpdateType.Major;
            if (latestVersion.Minor != CurrentVersion.Minor)
                return UpdateType.Minor;
            if (latestVersion.Patch != CurrentVersion.Patch)
                return UpdateType.Patch;

            return UpdateType.None;
        }

        public async Task<string> RenderReleaseNotes()
        {
            if (LatestRelease == null)
                throw new InvalidOperationException();

            return await Github.Miscellaneous.RenderRawMarkdown(LatestRelease.Body);
        }

        public /*async*/ void DownloadAsset(string assetname)
        {
            // asset.Url is some api wizardry that we'll maybe use later
            //var assets = await _releaseClient.GetAssets(RepositoryOwner, RepostoryName, LatestRelease.Id);
            //var asset = assets.First(n => n.Name == assetname);
            
            // for now, do some ugly shit
            const string template = "https://github.com/{0}/{1}/releases/download/{2}/{3}";
            var url = string.Format(template, RepositoryOwner, RepostoryName, LatestRelease.TagName, assetname);

            System.Diagnostics.Process.Start(url);
        }
    }
}
