using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{

    public int sceneToLoad;

    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
        Debug.Log("Game Started!");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
    }


}
