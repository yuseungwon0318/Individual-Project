using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text current;
    public Text best;
    public Image img;

    public Sprite SSS;
    public Sprite SS;
    public Sprite S;
    public Sprite A;
    public Sprite B;
    public Sprite C;
    public Sprite D;

    void Start()
    {
        
        float cur = PlayerPrefs.GetFloat("Current");

       

        if(cur >= 120)
        {
            img.sprite = SSS;
        }
        else if(cur >= 100 && 120 >= cur)
        {
            img.sprite = SS;
        }
        else if(cur >= 80 && 100 >= cur)
        {
            img.sprite = S;
        } 
        else if(cur >= 60 && 80 >= cur)
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

    // Update is called once per frame
    void Update()
    {
        current.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("Current"));
        best.text = string.Format("{0:N2}", PlayerPrefs.GetFloat("Best"));
    }
}
