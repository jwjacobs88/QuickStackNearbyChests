using UnityEngine;

[ModTitle("Your Mod Name")] // The mod name.
[ModDescription("Your Mod Description")] // Short description for the mod.
[ModAuthor("Author Name")] // The author name of the mod.
[ModIconUrl("Icon Url")] // An icon for your mod. Its recommended to be 128x128px and in .jpg format.
[ModWallpaperUrl("Banner Url")] // A banner for your mod. Its recommended to be 330x100px and in .jpg format.
[ModVersionCheckUrl("Version File Url")] // This is for update checking. Needs to be a .txt file with the latest mod version.
[ModVersion("1.0")] // This is the mod version.
[RaftVersion("Update Name")] // This is the recommended raft version.
[ModIsPermanent(false)] // If your mod add new blocks, new items or just content you should set that to true. It loads the mod on start and prevents unloading.
public class QuickStackNearbyChests : Mod
{
    // The Start() method is being called when your mod gets loaded.
    public void Start()
    {
        RConsole.Log("QuickStackNearbyChests has been loaded!");
    }

    // The Update() method is being called every frame. Have fun!
    public void Update()
    {
        
    }

    // The OnModUnload() method is being called when your mod gets unloaded.
    public void OnModUnload()
    {
        RConsole.Log("QuickStackNearbyChests has been unloaded!");
        Destroy(gameObject); // Please do not remove that line!
    }
}
