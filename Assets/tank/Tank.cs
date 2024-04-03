using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] Animator animator;
    float animationSpeed = 0f;
    float bearing = 0;
    Vector3 direction;
    float speed = 0f;
    Vector3 velocity;
    [SerializeField] float axis;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(Mathf.Sin(bearing * Mathf.Deg2Rad), Mathf.Cos(bearing * Mathf.Deg2Rad), 0);
        speed += Input.GetAxis("Vertical") * 0.1f;
        bearing += Input.GetAxis("Horizontal");
        animator.speed = speed;
        transform.position += direction * speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, -bearing);
    }
}
