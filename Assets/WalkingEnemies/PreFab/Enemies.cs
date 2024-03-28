using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    [SerializeField] AmyWalking amy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.value < 0.001)
        {
            AmyWalking newAmy = Instantiate(amy);
        }
        
    }
}
