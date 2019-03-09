# PlayFabBuddy.Core
Nuget package for the Xamarin PlayFab SDK

This is a nuget package for the Xamarin PlayFab ClientSDK.

Step 1:
Install the nuget package:
https://www.nuget.org/packages/PlayFabBuddy.Core/

Step 2:
Add the PlayFabClient to your IoC container:
```
var client = new PlayFabClient("YOUR PLAYFAB APP ID!!!");
Services.AddService<IPlayFabClient>(client);
```

Step 3:
Pull from IoC container and use:
```
var client = Services.GetService<IPlayFabClient>();
client.LinkCustomIDAsync(...)
etc.
```
