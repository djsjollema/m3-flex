using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 velocity = new Vector3(0.5f, 1, 0);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("halloooowww joenietie");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * 10 * Time.deltaTime;

        if(transform.position.y > 3 || transform.position.y < -3)
        {
            velocity = new Vector3(velocity.x, -velocity.y, 0);
        }

        if(transform.position.x >5 || transform.position.x < -5)
        {
            velocity = new Vector3(-velocity.x, velocity.y, 0);
        }
    }
}
