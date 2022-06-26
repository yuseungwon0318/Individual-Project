using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText;
    public float time;

    public void Update()
    {

         time += Time.deltaTime;
         timeText.text = string.Format("{0:N2}", time);
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("D"))
        {
            PlayerPrefs.SetFloat("Current", time);
           
        }
        if (other.CompareTag("U"))
        {
            PlayerPrefs.SetFloat("Current", time);

        }
        if (other.CompareTag("L"))
        {
            PlayerPrefs.SetFloat("Current", time);

        }
        if (other.CompareTag("R"))
        {
            PlayerPrefs.SetFloat("Current", time);

        }
        else
        {
           
        }

    }
}
