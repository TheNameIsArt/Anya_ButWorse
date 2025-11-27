using UnityEngine;

public class ResourceNode : MonoBehaviour
{
    public int hitsToBreak = 3;
    public int currentHits = 0;
    public string resourceType;

    void OnTriggerEnter(Collider other)
    {
        // Making sure that player can't collect object by walking into it
        if (other.CompareTag("Player"))
        {
            return; // walking into it does nothing
        }

        if  (other.CompareTag("Tool"))
        {
            currentHits++;

            if (currentHits < hitsToBreak)
            {
                Destroy(gameObject);

                // Add items to inventory
                Inventory inv = GameObject.FindWithTag("Player").GetComponent<Inventory>();

                if (resourceType == "Rock") inv.AddRock();
                if (resourceType == "Wood") inv.AddStick();
            }
        }
    }
}
