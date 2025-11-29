using UnityEngine;
using UnityEngine.UI;

public class UICursorFollow : MonoBehaviour
{
    public RectTransform cursor;

    void Update()
    {
        cursor.position = Input.mousePosition;
    }
}
