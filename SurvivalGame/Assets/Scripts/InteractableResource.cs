using UnityEngine;

public enum ResourceType { Wood, Stone }
public class InteractableResource : MonoBehaviour
{
    public ResourceType type;
    public int amount = 1;
    public float health = 3f;
    public GameObject dropPrefab;

    void OnMouseDown()
    {
        health -= 1f;

        if (health <= 0)
        {
            for (int i = 0; i < amount; i++)
                Instantiate(dropPrefab, transform.position + Random.insideUnitSphere * 0.5f, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
