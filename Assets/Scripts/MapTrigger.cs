using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTrigger : MonoBehaviour
{
    public GameObject mapUI;
    private bool mapShowing;
    // Start is called before the first frame update
    void Start()
    {
        mapUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            mapUI.SetActive(true);
            mapShowing = true;
        }
    }
}
