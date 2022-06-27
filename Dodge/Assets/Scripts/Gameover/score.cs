using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text current;
    public Text best;
    public Image img;
    public Image modeimg;
    float cur;
    public Sprite SSS;
    public Sprite SS;
    public Sprite S;
    public Sprite A;
    public Sprite B;
    public Sprite C;
    public Sprite D;

    public Sprite easy;
    public Sprite normal;
    public Sprite hard;
    public Sprite custom;

    void Start()
    {
        if (ModeManager.mode == "easy")
        {
            cur = PlayerPrefs.GetFloat("eCurrent");
        }
        if (ModeManager.mode == "normal")
        {
            cur = PlayerPrefs.GetFloat("nCurrent");
        }
            if (ModeManager.mode == "hard")
        {
             cur = PlayerPrefs.GetFloat("hCurrent");
        }
        if (ModeManager.mode == "custom")
        {
             cur = PlayerPrefs.GetFloat("cCurrent");
        }
       

        if (ModeManager.mode == "easy")
        {
            modeimg.sprite = easy;

            if (cur >= 120)
            {
                img.sprite = SSS;
            }
            else if (cur >= 100 && 120 >= cur)
            {
                img.sprite = SS;
            }
            else if (cur >= 80 && 100 >= cur)
            {
                img.sprite = S;
            }
            else if (cur >= 60 && 80 >= cur)
            {
                img.sprite = A;
            }
            else if (cur >= 40 && 60 >= cur)
            {
                img.sprite = B;
            }
            else if (cur >= 20 && 40 >= cur)
            {
                img.sprite = C;
            }
            else if (20 > cur)
            {
                img.sprite = D;
            }
        }
        else if (ModeManager.mode == "normal" || ModeManager.mode == "custom")
        {
            modeimg.sprite = normal;

            if (cur >= 90)
            {
                img.sprite = SSS;
            }
            else if (cur >= 75 && 90 >= cur)
            {
                img.sprite = SS;
            }
            else if (cur >= 60 && 75 >= cur)
            {
                img.sprite = S;
            }
            else if (cur >= 45 && 60 >= cur)
            {
                img.sprite = A;
            }
            else if (cur >= 30 && 45 >= cur)
            {
                img.sprite = B;
            }
            else if (cur >= 15 && 30 >= cur)
            {
                img.sprite = C;
            }
            else if (15 > cur)
            {
                img.sprite = D;
            }
        }
        else if (ModeManager.mode == "hard")
        {
            modeimg.sprite = hard;

            if (cur >= 60)
            {
                img.sprite = SSS;
            }
            else if (cur >= 50 && 60 >= cur)
            {
                img.sprite = SS;
            }
            else if (cur >= 40 && 50 >= cur)
            {
                img.sprite = S;
            }
            else if (cur >= 30 && 40 >= cur)
            {
                img.sprite = A;
            }
            else if (cur >= 20 && 30 >= cur)
            {
                img.sprite = B;
            }
            else if (cur >= 10 && 20 >= cur)
            {
                img.sprite = C;
            }
            else if (10 > cur)
            {
                img.sprite = D;
            }
        }

       

    }

    // Update is called once per frame
    void Update()
    {
        if (ModeManager.mode == "easy")
        {
            current.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("eCurrent"));
            best.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("eBest"));
        }
        if (ModeManager.mode == "normal")
        {
            current.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("nCurrent"));
            best.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("nBest"));
        }
        if (ModeManager.mode == "hard")
        {
            current.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("hCurrent"));
            best.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("hBest"));
        }
        if (ModeManager.mode == "custom")
        {
            current.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("cCurrent"));
            best.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("cBest"));
        }

       
    }
}
