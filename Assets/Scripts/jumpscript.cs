using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscript : MonoBehaviour
{

	Rigidbody2D rb;
	public float jumpforce;
	bool grounded;
    bool gameover = false;

	Animator anim;

	private void Awake()
	{
		rb=GetComponent<Rigidbody2D>();
		grounded = true;
		anim = GetComponent<Animator>();
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetMouseButtonDown(0) && grounded && !gameover)
    	{
    		Jump();
    	}
        
    }

    void Jump()
    {
    	anim.SetTrigger("Jump");
    	grounded = false;
    	rb.velocity = Vector2.up * jumpforce;
        manager.instance.incrementScore();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    	if(collision.gameObject.tag == "Ground")
    	{
    		grounded = true;
    	}
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "obstacles")
        {
            //manager.instance.GameOver();
            //Destroy(collision.gameObject);
            //anim.Play("Death");
            //gameover = true;
        }
    }
}
