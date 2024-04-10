using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromAtoB : MonoBehaviour
{
    Vector3 velocity = new Vector3(1, 1, 0);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hallo yoenietie");
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
        if(transform.position.y > 3 || transform.position.y < -3)
        {
            velocity = new Vector3(velocity.x, -velocity.y, 0);
        }

        if (transform.position.x > 5 || transform.position.x < -5)
        {
            velocity = new Vector3(-velocity.x, velocity.y, 0);
        }
    }
}
