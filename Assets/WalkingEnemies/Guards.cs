using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guards : MonoBehaviour
{
    [SerializeField] CastleGuard guard; 

    void Update()
    {
        if(Random.value < 0.001f)
        {
            CastleGuard guard_copy = Instantiate(guard);
        }
        
    }
}
