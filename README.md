GitHub Update
=============

Easy way to check if your C# program is up to date using GitHub Releases

Installing
----------
```
PM> Install-Package GitHubUpdate
```

Example
-------
```csharp
var checker = new UpdateChecker("nixxquality", "WebMConverter", "2.3.0")

UpdateType update = checker.CheckUpdate().Result; // this is a Task, so you could also ContinueWith

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
