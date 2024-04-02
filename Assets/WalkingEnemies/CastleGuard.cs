using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleGuard : MonoBehaviour
{
    [SerializeField] GameObject A;
    [SerializeField] GameObject B;

    Vector3 velocity;
    Vector3 direction;
    float speed = 2f;
    float distance;

    void Start()
    {
        transform.position = A.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        direction = B.transform.position - transform.position;
        distance = direction.magnitude;
        direction = direction.normalized;
        velocity = direction * speed * Time.deltaTime;
        transform.position += velocity;
        transform.LookAt(B.transform.position);
        if(distance < speed * Time.deltaTime)
        {
            Destroy(gameObject);
        }
    }
}
