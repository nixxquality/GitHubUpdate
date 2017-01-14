GitHub Update [![Project Status: Unsupported - The project has reached a stable, usable state but the author(s) have ceased all work on it. A new maintainer may be desired.](http://www.repostatus.org/badges/latest/unsupported.svg)](http://www.repostatus.org/#unsupported)
=============

**This project has been abandoned** by the owner as I do not use GitHub anymore. Feel free to fork and improve it, if you'd like.

If you want to take over the NuGet package, go ahead and contact me at nixx@is-fantabulo.us.

--------------

Easy way to check if your C# program is up to date using GitHub Releases

Installing
----------
```
PM> Install-Package GitHubUpdate
```

Example
-------
```csharp
var checker = new UpdateChecker("nixxquality", "WebMConverter") // uses your Application.ProductVersion

UpdateType update = await checker.CheckUpdate();

if (update == UpdateType.None)
{
  // Up to date!
}
else
{
  // Ask the user if he wants to update
  // You can use the prebuilt form for this if you want (it's really pretty!)
  var result = new UpdateNotifyDialog(checker).ShowDialog();
  if (result == DialogResult.Yes)
  {
    checker.DownloadAsset("Converter.zip"); // opens it in the user's browser
  }
}
```
See also the Sample project included in the repository.
