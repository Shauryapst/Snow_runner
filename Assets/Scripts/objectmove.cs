﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectmove : MonoBehaviour
{

	Rigidbody2D rb;

	public float moveSpeed;


	private void Awake()
	{
		rb=GetComponent<Rigidbody2D>();
	}



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(transform.position.x<-15f)
    	{
    		Destroy(gameObject);
    	}
        
    }
    private void FixedUpdate()
    {
    	rb.velocity = -Vector2.left * moveSpeed;
    }
}
