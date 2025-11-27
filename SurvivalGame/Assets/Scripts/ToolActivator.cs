using UnityEngine;

public class ToolActivator : MonoBehaviour
{
    public Collider hitbox;

    void Start()
    {
        hitbox.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ActivateTool());
        }
    }

    System.Collections.IEnumerator ActivateTool()
    {
        hitbox.enabled = true;
        yield return new WaitForSeconds(0.2f);
        hitbox.enabled = false;
    }
}
