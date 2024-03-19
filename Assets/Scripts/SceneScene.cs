using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class FirstCutScene : MonoBehaviour
{

    public string scenename;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            nextScene();
            Debug.Log("Change.");
        }
    }

    void nextScene()
    {
        SceneManager.LoadScene(scenename);
    }

    

}