using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class home : MonoBehaviour
{
    public Text EBS;
    public Text NBS;
    public Text HBS;
    public Text CBS;

    public GameObject a;

    public void gohome()
    {
        a.SetActive(false);
    }

    private void Start()
    {
        EBS.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("eBest"));
        NBS.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("nBest"));
        HBS.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("hBest"));
        CBS.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("cBest"));
    }
}
