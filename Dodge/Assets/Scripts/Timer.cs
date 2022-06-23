using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText;
    private float time;

    private void Update()
    {
        time += Time.deltaTime;
        timeText.text = string.Format("{0:N2}", time);
    }
}
