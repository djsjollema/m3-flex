using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Droplet : MonoBehaviour
{
    public float ymin;
    public UnityEvent myEvent;
    

    Vector3 velocity = Vector3.zero;
    float speed = -1f;

    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector3(0, speed, 0);
        if(myEvent == null) myEvent = new UnityEvent();
        myEvent.AddListener(drop);
    }


    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
        if(transform.position.y < ymin)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
        myEvent.Invoke();
    }

    void drop()
    {
        Debug.Log("drop");
    }

}
