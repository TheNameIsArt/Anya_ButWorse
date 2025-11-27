using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3 (0, 12, -8);
    public float panSpeed = 10f;
    public float zoomSpeed = 10f;
    public float minZoom = 6f, maxZoom = 20f;
    public bool followPlayer = true;
    Vector3 velocity;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) followPlayer = !followPlayer;

        Vector3 panInput = Vector3.zero;
        if (!followPlayer)
        {
            panInput.x = Input.GetAxis("Horizontal");
            panInput.z = Input.GetAxis("Vertical");
            transform.position += panInput * panSpeed * Time.deltaTime;
        }

        float scroll = Input.mouseScrollDelta.y;
        offset += offset.normalized * (-scroll) * zoomSpeed * Time.deltaTime;
        offset = Vector3.ClampMagnitude(offset, maxZoom);

        if (offset.magnitude < minZoom) offset = offset.normalized * minZoom;
    }
}
