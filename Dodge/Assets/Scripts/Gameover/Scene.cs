using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void play()
    {
       

        if (ModeManager.mode == "easy")
        {
            ModeManager.easy();
        }
        if (ModeManager.mode == "normal")
        {
            ModeManager.normal();
        }
        if (ModeManager.mode == "hard")
        {
            ModeManager.hard();
        }
        if (ModeManager.mode == "custom")
        {
            ModeManager.custom();
        }

        SceneManager.LoadScene("Play");
    }
    public void home()
    {
        SceneManager.LoadScene("Start");
    }
}
