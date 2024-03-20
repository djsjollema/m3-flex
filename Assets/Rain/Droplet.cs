using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Droplet : MonoBehaviour
{
    public float ymin;
    public UnityEvent myEvent; 
    

    float speed = 2f;
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
      
        velocity = Vector3.down * speed;
        if(myEvent == null) myEvent = new UnityEvent();
    }


    // Update is called once per frame
    void Update()
    {
        //velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
        if(transform.position.y < ymin)
        {
            Destroy(this.gameObject);
            myEvent.Invoke();
        }
    }

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
        myEvent.Invoke();
    }

    public void drop()
    {
        Debug.Log("drop");
    }

}
