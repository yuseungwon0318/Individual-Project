using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;

    static public float difficulty = 3;
    
    
    public void Start()
    {
        StartCoroutine(Spawning());
        StartCoroutine(time());
    }

    IEnumerator Spawning()
    {
        while(true)
        {
            if(gameObject.CompareTag("UU"))
            {
                float positionX = Random.Range(-8.6f, 8.6f);

                Vector3 EnemyPosition = new Vector3(positionX, transform.position.y);

                Instantiate(Enemy, EnemyPosition, transform.rotation);
            }
            if(gameObject.CompareTag("DD"))
            {
                float positionX = Random.Range(-8.6f, 8.6f);

                Vector3 EnemyPosition = new Vector3(positionX, transform.position.y);

                Instantiate(Enemy, EnemyPosition, transform.rotation);
            }
            if (gameObject.CompareTag("RR"))
            {
                float positionY = Random.Range(-4.8f, 4.8f);

                Vector3 EnemyPosition = new Vector3(transform.position.x, positionY);

                Instantiate(Enemy, EnemyPosition, transform.rotation);
            }
            if (gameObject.CompareTag("LL"))
            {
                float positionY = Random.Range(-4.8f, 4.8f);

                Vector3 EnemyPosition = new Vector3(transform.position.x, positionY);

                Instantiate(Enemy, EnemyPosition, transform.rotation);
            }



            yield return new WaitForSeconds(difficulty);
        }
    }

    private void Update()
    {
    
        //Debug.Log(difficulty);
        //Debug.Log(Time.realtimeSinceStartup);
 
    }

    IEnumerator time()
    {
       
        while(true)
        {
            if (difficulty <= 0.6)
            {
                
            }
            else
            {
                difficulty -= 0.1f;
                yield return new WaitForSeconds(10f);

            }
            yield return null;
        }
        
        
    }

}
