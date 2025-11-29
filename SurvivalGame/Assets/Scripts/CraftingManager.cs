using UnityEngine;

public class CraftingManager : MonoBehaviour
{
    public Inventory playerInventory;
    public Transform spawnPoint;

    // Example craft: build a campfire
    public GameObject campfirePrefab;
    public int campfireRockCost = 2;
    public int campfireStickCost = 3;

    public void CraftCampfire()
    {
        if (playerInventory.rockCount >= campfireRockCost &&
            playerInventory.stickCount >= campfireStickCost)
        {
            // Remove resources
            playerInventory.rockCount -= campfireRockCost;
            playerInventory.stickCount -= campfireStickCost;
            playerInventory.SendMessage("UpdateInventoryUI");

            // Spawn crafted item
            Instantiate(campfirePrefab, spawnPoint.position, Quaternion.identity);
            Debug.Log("Crafted campfire!");
        }
        else
        {
            Debug.Log("Not enough materials to craft a campfire.");
        }
    }
}
