using UnityEngine;

public class RockCollect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Inventory>().AddRock();
            Destroy(gameObject);
        }
    }
}
