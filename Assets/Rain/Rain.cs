using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    [SerializeField] DropLet droplet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.value < 0.01)
        {
            DropLet copyDroplet = Instantiate(droplet);
        }
        
        
    }
}
