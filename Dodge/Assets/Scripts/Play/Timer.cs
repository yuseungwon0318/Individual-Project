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
        bestscore = PlayerPrefs.GetFloat("Best");
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
                
                bestscore = currentscore;
                PlayerPrefs.SetFloat("Current", currentscore);
                PlayerPrefs.SetFloat("Best", bestscore);

            }
            else
            {
                PlayerPrefs.SetFloat("Current", time);
            }
           
        }
       
        else
        {
           
        }

    }
}
