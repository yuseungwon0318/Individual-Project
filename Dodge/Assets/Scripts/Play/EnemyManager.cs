using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{

    float enemyspeed;
    static float enemymin= 2;
    static float enemymax= 5;

    Vector3 dir;
    
    
    private void Start()
    {
        float rds = Random.Range(enemymin, enemymax);

        enemyspeed = rds;

        int rd = Random.Range(0, 10);
        if (rd < 2)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();

        }
        else
        {
            if(gameObject.CompareTag("L"))
            {
                dir = Vector3.right;
            }

            if (gameObject.CompareTag("R"))
            {
                dir = Vector3.left;
            }

            if (gameObject.CompareTag("U"))
            {
                dir = Vector3.down;
            }

            if (gameObject.CompareTag("D"))
            {
                dir = Vector3.up;
            }


        }
    }
    void Update()
    {
        transform.Translate(dir * enemyspeed * Time.deltaTime);

       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }

   
   

        

    



}
