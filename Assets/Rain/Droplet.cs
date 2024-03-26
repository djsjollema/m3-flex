using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droplet : MonoBehaviour
{
    Vector3 velocity;
    float speed = 2f;

    void Start()
    {
        velocity = Vector3.down;
        transform.position = new Vector3(Random.Range(-8f, 8f), 5, 0);
    }

    void Update()
    {
        transform.position += velocity * speed * Time.deltaTime;
        
        if(transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
}
