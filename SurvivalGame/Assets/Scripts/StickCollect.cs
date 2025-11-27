using UnityEngine;

public class StickCollect : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Inventory>().AddStick();
            Destroy(gameObject);
        }
    }
}
