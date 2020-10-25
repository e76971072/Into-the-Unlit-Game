﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Travel : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;

    public Rigidbody2D rb;

    public GameObject impactEffect;


    public Transform firepoint; 
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;

    }

    // Update is called once per frame
    void Update()
    {

    }
    //void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log(collision.gameObject.name);
    //    Debug.Log(collision.gameObject.tag);

    //    if (collision.gameObject.tag != "RoomTrigger")
    //    {
    //        Destroy(gameObject);

    //        Instantiate(impactEffect, transform.position, transform.rotation);

    //    }


    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //gameObject.SendMessage("Got hit");

        if (collision.gameObject.tag == "CameraControl" || collision.gameObject.tag == "RoomSpawner")
        {
            return; 


        }

        Debug.Log(collision.gameObject.tag);
        Destroy(gameObject);

        Instantiate(impactEffect, transform.position, transform.rotation); Destroy(gameObject);
        Physics2D.IgnoreCollision(collision, collision);
    }
}
