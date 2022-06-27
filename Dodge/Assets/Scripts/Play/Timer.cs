using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText;
    public float time;


    float currentscore;
    float bestscore;

    private void Start()
    {

        if(ModeManager.mode == "easy")
        {
            bestscore = PlayerPrefs.GetFloat("eBest");
        }
        if (ModeManager.mode == "normal")
        {
            bestscore = PlayerPrefs.GetFloat("nBest");
        }
        if (ModeManager.mode == "hard")
        {
            bestscore = PlayerPrefs.GetFloat("hBest");
        }
        if (ModeManager.mode == "custom")
        {
            bestscore = PlayerPrefs.GetFloat("cBest");
        }
    }
    public void Update()
    {

         
         time += Time.deltaTime;
         timeText.text = string.Format("{0:N2}", time);
         currentscore = time;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("D") || other.CompareTag("U") || other.CompareTag("R") || other.CompareTag("L"))
        {
            if (currentscore >= bestscore)
            {

                if (ModeManager.mode == "easy")
                {
                    bestscore = currentscore;
                    PlayerPrefs.SetFloat("eCurrent", currentscore);
                    PlayerPrefs.SetFloat("eBest", bestscore);
                }
                if (ModeManager.mode == "normal")
                {
                    bestscore = currentscore;
                    PlayerPrefs.SetFloat("nCurrent", currentscore);
                    PlayerPrefs.SetFloat("nBest", bestscore);
                }
                if (ModeManager.mode == "hard")
                {
                    bestscore = currentscore;
                    PlayerPrefs.SetFloat("hCurrent", currentscore);
                    PlayerPrefs.SetFloat("hBest", bestscore);
                }
                if (ModeManager.mode == "custom")
                {
                    bestscore = currentscore;
                    PlayerPrefs.SetFloat("cCurrent", currentscore);
                    PlayerPrefs.SetFloat("cBest", bestscore);
                }
            }
            else
            {
                if(ModeManager.mode == "easy")
                {
  
                    PlayerPrefs.SetFloat("eCurrent", currentscore);
                    
                }
                if (ModeManager.mode == "normal")
                {
                    
                    PlayerPrefs.SetFloat("nCurrent", currentscore);
                   
                }
                if (ModeManager.mode == "hard")
                {
                   
                    PlayerPrefs.SetFloat("hCurrent", currentscore);
                  
                }
                if (ModeManager.mode == "custom")
                {
                    
                    PlayerPrefs.SetFloat("cCurrent", currentscore);
                   
                }
            }
           
        }
       
        else
        {
           
        }

    }
}
