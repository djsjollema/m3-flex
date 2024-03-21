using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropLet : MonoBehaviour
{
    Vector3 velocity;
    float speed;
    Vector2 minDim;
    Vector2 maxDim;

    void Start()
    {
        velocity = Vector3.down;
        maxDim = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        minDim = Camera.main.ScreenToWorldPoint(Vector2.zero);

        float xrandom = Random.Range(minDim.x, maxDim.x);
        transform.position = new Vector3(xrandom, maxDim.y + 0.2f, 0);
    }

    void Update()
    {
        transform.position += velocity * Time.deltaTime;

        if(transform.position.y < minDim.y)
        {
            Destroy(gameObject);
        }
    }
}
