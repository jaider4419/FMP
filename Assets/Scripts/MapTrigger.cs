using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Map;
    bool isShowing;

    void Start()
    {
        Map.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            if (isShowing)
            {
                ShowtheMap();
            }
            else
            {
                DontShow();
            }
        }

    }

    public void ShowtheMap()
    {
        isShowing=true;
        Map.SetActive(true);
    }

    public void DontShow()
    {
        isShowing=false;
        Map.SetActive(false);
    }
}