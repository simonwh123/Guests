using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void onPlay()
    {
        SceneManager.LoadScene("Level1");
    }

    public void onExit()
    {
        Application.Quit();
    }

    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/daddysucc5000");
    }
}
