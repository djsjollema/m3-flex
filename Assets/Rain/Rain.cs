using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rain : MonoBehaviour
{


    [SerializeField] Droplet droplet;

    Vector2 dimMin;
    Vector2 dimMax;



    // Start is called before the first frame update
    void Start()
    {
        dimMin = Camera.main.ScreenToWorldPoint(Vector2.zero);
        dimMax = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.value < 0.0015f)
        {
            float x = Random.Range(dimMin.x + 0.5f, dimMax.x - 0.5f);
            Droplet newDroplet = Instantiate(droplet, new Vector3(x,dimMax.y + 0.5f,0), Quaternion.identity);
            newDroplet.ymin = dimMin.y - 0.5f;

        }   
    }

    public void myAction()
    {
        Debug.Log("boop");
    }
}
