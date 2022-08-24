
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float planeAddSpeed { get; private set; } //incapsulation

    // Start is called before the first frame update
    void Start()
    {
        planeAddSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Movement(); //abstraction
    }

    public virtual void Movement()
    {
        speed = 22.5f;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
