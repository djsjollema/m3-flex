using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmyWalking : MonoBehaviour
{
    [SerializeField] Transform A;
    [SerializeField] Transform B;
    Vector3 direction;
    float speed = 1f;
    float distance;


    void Start()
    {
        transform.position = A.position;
        transform.LookAt(A.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = B.position - transform.position;
        distance = direction.magnitude;
        direction = direction.normalized;
        transform.LookAt(B.position);
        transform.position += direction * speed * Time.deltaTime;
        if(distance < 0.1f) 
        {
            Destroy(gameObject);
        }
    }
}
