using UnityEngine;
using UnityEngine.UI;

public class ToggleUI : MonoBehaviour
{
    public GameObject Map;

    private bool uiVisible = false;

    void Start()
    {
        // Ensure the UI element is initially hidden
        if (Map != null)
            Map.SetActive(false);
    }

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;   
        if (Input.GetKeyDown(KeyCode.M))
        {
            uiVisible = !uiVisible;
            if (Map != null)
                Map.SetActive(uiVisible);
        }
    }
}