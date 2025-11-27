using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public int rockCount = 0;
    public int stickCount = 0;

    [Header("UI References")]
    public TextMeshProUGUI inventoryText;
    void Start()
    {
        UpdateInventoryUI();
    }

    public void AddRock(int amount = 1)
    {
        rockCount += amount;
        UpdateInventoryUI();
    }

    public void AddStick(int amount = 1)
    {
        stickCount += amount;
        UpdateInventoryUI();
    }

    void UpdateInventoryUI()
    {
        inventoryText.text =
            "Inventory:\n" +
            "Rocks: " + rockCount + "\n" +
            "Sticks:" + stickCount;
    }
}
