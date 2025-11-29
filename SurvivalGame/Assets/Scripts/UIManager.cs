using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject craftingMenu;
    public GameObject crosshair;

    private bool menuOpen = false;

    void Update()
    {
        // Press E to toggle crafting menu
        if (Input.GetKeyDown(KeyCode.E))
        {
            ToggleMenu();
        }
    }

    public void ToggleMenu()
    {
        menuOpen = !menuOpen;

        craftingMenu.SetActive(menuOpen);
        crosshair.SetActive(!menuOpen);

        if (menuOpen)
        {
            // Unlock mouse so player can click buttons
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            // Lock mouse so player can control camera again
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
