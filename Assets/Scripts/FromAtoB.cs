using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromAtoB : MonoBehaviour
{
    [SerializeField] GameObject A;
    [SerializeField] GameObject B;
    [SerializeField] Vector3 differenceVector;
    [SerializeField] float distance;
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 2f;
    bool gotoB = true;

    void Start()
    {
        transform.position = A.transform.position;
    }

    void Update()
    {
        if (gotoB)
        {
            differenceVector = B.transform.position - transform.position;
            transform.LookAt(A.transform.position);
        } else
        {
            differenceVector = A.transform.position - transform.position;
            transform.LookAt(B.transform.position);
        }
        
        distance = differenceVector.magnitude;
        direction = differenceVector.normalized;
        transform.position += direction * speed * Time.deltaTime;

        if(distance < speed*Time.deltaTime )
        {
            gotoB = !gotoB;
        }
    }
}
