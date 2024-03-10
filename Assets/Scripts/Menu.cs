using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public string scenename;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartGame()
    {
        SceneManager.LoadScene(scenename);
    }

    void ExitGame()
    {
        Application.Quit();
    }
}
