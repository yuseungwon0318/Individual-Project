using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playS : MonoBehaviour
{
    public void clicks()
    {
        if(ModeManager.mode != "easy" && ModeManager.mode != "normal" && ModeManager.mode != "hard" && ModeManager.mode != "custom")
        {
            ModeManager.mode = "normal";
        }
        else if(ModeManager.mode == "easy")
        {
            ModeManager.easy();
        }
        else if (ModeManager.mode == "normal")
        {
            ModeManager.normal();
        }
        else if (ModeManager.mode == "hard")
        {
            ModeManager.hard();
        }
        else if (ModeManager.mode == "custom")
        {
            ModeManager.custom();
        }

        SceneManager.LoadScene("Play");
    }
    public void clicko()
    {
        SceneManager.LoadScene("Mode");
    }
}
