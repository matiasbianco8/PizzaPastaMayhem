﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaCarniceroManager : MonoBehaviour
{
    public GameObject playerBody; //En el start puse que busque al jugador, sino traer objeto del jugador

    public GameObject CarniceroBody;

    public float timer = 2.5f; // tiempo para su destruccion

    private float balaSpeed;  // velocidad de la bala

    public float manualSpeed = 10; // velocidad de la bala

    private SpriteRenderer BalaEnemiga;

    private Rigidbody2D RBBala;






    // Start is called before the first frame update
    void Start()
    {
        RBBala = GetComponent<Rigidbody2D>();

        BalaEnemiga = GetComponent<SpriteRenderer>();

        playerBody = GameObject.FindGameObjectWithTag("Player"); // detecta al jugador

        CarniceroBody = GameObject.FindGameObjectWithTag("Carnicero");

        if (CarniceroBody.transform.position.x < transform.position.x)      //checkea si el robot está de un lado o no
        {
            balaSpeed = (manualSpeed * 1); // velocidad de la bala

            BalaEnemiga.flipX = true;  //Flipear (o no) sprite
        }

        else if (CarniceroBody.transform.position.x > transform.position.x)     //checkea si el robot está de un lado o no
        {
            balaSpeed = (manualSpeed * -1); // velocidad de la bala

            BalaEnemiga.flipX = false;  //Flipear (o no) sprite
        }



        RBBala.velocity = new Vector2(balaSpeed, RBBala.velocity.y);        //movimiento de la bala en una direccion


        Destroy(gameObject, timer); //Destruye gameobject y en cuanto tiempo
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
