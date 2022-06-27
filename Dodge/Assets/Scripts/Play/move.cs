using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    Vector3 dir;
    public float speed = 5;

    private void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        dir = new Vector3(h, v);

        transform.position += dir * speed * Time.deltaTime;

        
        if (transform.position.x >= 8.6 || transform.position.x <= -8.6 || transform.position.y >= 4.7 || transform.position.y <= -4.7)
        {

            Vector3 vec = transform.position;

            vec.x = Mathf.Clamp(vec.x, -8.6f, 8.6f);
            vec.y = Mathf.Clamp(vec.y, -4.7f, 4.7f);

            transform.position = vec;
        }

        
        

    }
}
