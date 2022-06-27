using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeManager : MonoBehaviour
{

    static public string mode;

    static public void easy()
    {
        EnemyManager.enemymin = 2;
        EnemyManager.enemymax = 4;
        Spawner.difficulty = 4;

        mode = "easy";
    }
    static public void normal()
    {
        EnemyManager.enemymin = 3;
        EnemyManager.enemymax = 6;
        Spawner.difficulty = 2;

        mode = "normal";
    }
    static public void hard()
    {
        EnemyManager.enemymin = 4;
        EnemyManager.enemymax = 8;
        Spawner.difficulty = 1.5f;

        mode = "hard";
    }
    static public void custom()
    {
        SceneManager.LoadScene("Option");


        mode = "custom";
    }
    public void play()
    {
        SceneManager.LoadScene("Play");
    }



}
