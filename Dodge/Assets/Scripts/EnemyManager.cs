using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public GameObject explosionFactory;

    float speed;
    Vector3 dir;
    private void Start()
    {
        float rds = Random.Range(2f, 5f);

        speed = rds;

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
        transform.Translate(dir * speed * Time.deltaTime);
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
