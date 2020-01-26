using System.Collections.Generic;
using UnityEngine;

[ModTitle("Quick Stack Nearby Chests")] // The mod name.
[ModDescription("Quickly Stack Items into Nearby Chests that contain those items")] // Short description for the mod.
[ModAuthor("MrScruff")] // The author name of the mod.
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
        if (CanvasHelper.ActiveMenu == MenuType.Inventory && Input.GetKeyDown(KeyCode.Z))
        {
            Network_Player player = RAPI.getLocalPlayer();
            if (player != null)
            {
                this.PrintPlayerInventory(player);
            }
        }
    }

    private void PrintPlayerInventory(Network_Player player)
    {
        PlayerInventory inventory = player.Inventory;

        List<Slot> nonHotbar = inventory.allSlots.GetRange(player.Inventory.hotslotCount, player.Inventory.allSlots.Count);
        RConsole.Log($"Player has {player.Inventory.allSlots.Count} slots");
        foreach (Slot slot in nonHotbar)
        {
            if (slot.IsEmpty == true) {
                RConsole.Log("Empty");
            } else {
                 
                RConsole.Log($"{slot.GetItemBase().UniqueName as string} {slot.itemInstance.Amount}/{slot.itemInstance.settings_Inventory.StackSize}");
            }
        }
    }

    // The OnModUnload() method is being called when your mod gets unloaded.
    public void OnModUnload()
    {
        RConsole.Log("QuickStackNearbyChests has been unloaded!");
        Destroy(gameObject); // Please do not remove that line!
    }
}
