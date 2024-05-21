Notes:
* Code referenced from Reddit https://www.reddit.com/r/skyrimmods/comments/m6289o/running_skse_through_mo2_through_steam_launcher/
* This is essentially turning the ModOrganizer SKSE shortcut into its own application file.

# How to Build
1. In Visual Studio, right click the project > "Publish". (or Build > Publish)
* https://learn.microsoft.com/en-us/dotnet/core/deploying/single-file/overview?tabs=vs
2. Keep "Deployment Mode" as "Framework-dependent" to reduce file size.
3. "File Publish Options" > Enable "Produce single file".
4. Click "Publish".

# How to Use
1. Locate the published `SKSE_ModOrganizer_Shortcut.exe` file. (Should be in /bin/Release/net8.0/publish/win-x86)
2. Move/copy it to Skyrim installation directory.
3. Rename original `SkyrimSELauncher.exe` (ex: `SkyrimSELauncher_ORIGINAL.exe`)
4. Rename `SKSE_ModOrganizer_Shortcut.exe` to `SkyrimSELauncher.exe`.
5. Now Steam will launch this application which will launch ModOrganizer SKSE.
