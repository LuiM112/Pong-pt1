using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Vector3 direction;
    public float speed;

    private void Start()
    {
        this.direction = new Vector3(1f, 0f, 1f);
    }

    private void Update()
    {
        this.transform.position += direction * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 normal = collision.contacts[0].normal;
        direction = Vector3.Reflect(direction, normal);
    }
    
}
