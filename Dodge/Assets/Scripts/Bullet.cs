using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    Vector3 dir;

    public void Start()
    {


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            dir = Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            dir = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            dir = Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            dir = Vector3.down;
        }
    }

    void Update()
    {

        transform.position += dir * speed * Time.deltaTime;

    }
}
