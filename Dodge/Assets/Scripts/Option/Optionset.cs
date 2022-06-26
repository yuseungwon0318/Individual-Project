using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Optionset : MonoBehaviour
{
    
    public Text Enemyspeedmin;
    public Text Enemyspeedmax;
    public Text EnemySpawnTime;
    public void enemyspeedminp()
    {
        if(EnemyManager.enemymin <= 4)
        {
            EnemyManager.enemymin++;
            PlayerPrefs.SetFloat("enemyspdmin", EnemyManager.enemymin);
        }
        else
        {
            EnemyManager.enemymin = 5;
        }
    }
    public void enemyspeedminm()
    {
        if (EnemyManager.enemymin >= 2)
        {
            EnemyManager.enemymin--;
            PlayerPrefs.SetFloat("enemyspdmin", EnemyManager.enemymin);
        }
        else
        {
            EnemyManager.enemymin = 1;
        }
    }
    public void enemyspeedmaxp()
    {
        if (EnemyManager.enemymax <= 9)
        {
            EnemyManager.enemymax++;
            PlayerPrefs.SetFloat("enemyspdmax", EnemyManager.enemymax);
        }
        else
        {
            EnemyManager.enemymax = 10;
        }
    }
    public void enemyspeedmaxm()
    {
        if (Spawner.difficulty >= 5)
        {
            EnemyManager.enemymax--;
            PlayerPrefs.SetFloat("enemyspdmax", EnemyManager.enemymax);
        }
        else
        {
            EnemyManager.enemymax = 6;
        }
    } 
    public void enemyspawntimep()
    {
        if (Spawner.difficulty <= 2.9)
        {
            Spawner.difficulty += 0.1f;
            PlayerPrefs.SetFloat("enemyspawntime", Spawner.difficulty);
        }
        else
        {
            Spawner.difficulty = 3;
        }
    }
    public void enemyspawntimem()
    {
        if (Spawner.difficulty >= 1.1)
        {
            Spawner.difficulty -= 0.10f;
            PlayerPrefs.SetFloat("enemyspawntime", Spawner.difficulty);
        }
        else
        {
            Spawner.difficulty = 1;
        }
    }

    public void Update()
    {
        Enemyspeedmin.text = "" + EnemyManager.enemymin;
        Enemyspeedmax.text = "" + EnemyManager.enemymax;
        EnemySpawnTime.text = string.Format("{0:N1}", Spawner.difficulty);
    }
    private void Start()
    {
        Spawner.difficulty = PlayerPrefs.GetFloat("enemyspawntime");
        EnemyManager.enemymin = PlayerPrefs.GetFloat("enemyspdmin");
        EnemyManager.enemymax = PlayerPrefs.GetFloat("enemyspdmax");
       
    }
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void firstload()
    {
        Spawner.difficulty = 1;
        EnemyManager.enemymin = 3;
        EnemyManager.enemymax = 8;
    }
}
