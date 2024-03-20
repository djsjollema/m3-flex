using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rain : MonoBehaviour
{

    [SerializeField] Droplet droplet;
    [SerializeField] GameObject water;

    Vector2 dimMin;
    Vector2 dimMax;
    float width;
    float waterHeight = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        dimMin = Camera.main.ScreenToWorldPoint(Vector2.zero);
        dimMax = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        float width = dimMax.x - dimMin.x;
        water.transform.localScale = new Vector3(width, waterHeight, 0);
        water.transform.position = new Vector3(0,dimMin.y + waterHeight, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.value < 0.010f)
        {
            float x = Random.Range(dimMin.x + 0.5f, dimMax.x - 0.5f);
            Droplet newDroplet = Instantiate(droplet, new Vector3(x,dimMax.y + 0.5f,0), Quaternion.identity);
            newDroplet.ymin = dimMin.y - 0.5f;

        }   
    }

    public void Grow()
    {
        waterHeight += 0.1f;
        water.transform.localScale +=  new Vector3(0, 0.1f, 0);
        water.transform.position = new Vector3(0, 0.1f, 0);
        Debug.Log(water.transform.localScale += new Vector3(0, 0.1f, 0));
    }
}
