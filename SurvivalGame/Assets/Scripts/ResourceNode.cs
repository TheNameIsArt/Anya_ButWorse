using UnityEngine;

public class ResourceNode : MonoBehaviour
{
    public int hitsToBreak = 3;
    public int currentHits = 0;
    public string resourceType;  // "Rock" or "Wood"

    private bool isBroken = false;

    void OnTriggerEnter(Collider other)
    {
        // Walking into it does nothing
        if (other.CompareTag("Player"))
            return;

        // Only tools trigger hits
        if (other.CompareTag("Tool") && !isBroken)
        {
            currentHits++;

            // Only break when the required number of hits is reached
            if (currentHits >= hitsToBreak)
            {
                BreakNode();
            }
        }
    }

    void BreakNode()
    {
        isBroken = true;

        Inventory inv = GameObject.FindWithTag("Player").GetComponent<Inventory>();

        if (resourceType == "Rock")
            inv.AddRock();
        else if (resourceType == "Wood")
            inv.AddStick();

        Destroy(gameObject);
    }
}
