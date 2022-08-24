using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlane : Enemy
{
    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public override void Movement() //polymorphism
    {
        speed = 22.5f + planeAddSpeed; 
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
