using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    Vector3 velocity;
    Vector3 direction = new Vector3(1,0,0);
    float speed = 1f;

    Vector2 maxBorder;
    Vector2 minBorder;


    void Start()
    {
        Debug.Log(Screen.width + " " + Screen.height);

        minBorder = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        maxBorder = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        Debug.Log(minBorder + " " + maxBorder);
        
    }

    void Update()
    {
        velocity = direction * speed;
        transform.position += velocity * Time.deltaTime;

        if(transform.position.x > maxBorder.x)
        {
            transform.position = new Vector3(minBorder.x, transform.position.y, 0);
        }
    }
}
