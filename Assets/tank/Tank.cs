using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    Vector3 velocity;
    Vector3 direction;
    float speed = 1;
    [SerializeField] float bearing = 0f;

    Vector2 minBorders;
    Vector2 maxBorders;

    void Start()
    {
        minBorders = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        maxBorders = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        //Debug.Log(minBorders + " " + maxBorders); 
        //
    }

    void Update()
    {
        direction = new Vector3(Mathf.Cos(bearing * Mathf.Deg2Rad), Mathf.Sin(bearing * Mathf.Deg2Rad), 0);

        velocity = direction * speed;
        transform.position += velocity * Time.deltaTime;

        transform.rotation = Quaternion.Euler(0, 0, bearing);

        if (transform.position.y > maxBorders.y)
        {
            transform.position = new Vector3(transform.position.x, minBorders.y, 0);
        }

        if (transform.position.y < minBorders.y)
        {
            transform.position = new Vector3(transform.position.x, maxBorders.y, 0);
        }

        if (transform.position.x > maxBorders.x)
        {
            transform.position = new Vector3(minBorders.x, transform.position.y, 0);
        }

        if (transform.position.x < minBorders.x)
        {
            transform.position = new Vector3(maxBorders.x, transform.position.y, 0);
        }



    }
}
