using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backScroll : MonoBehaviour
{

    public static backScroll instance;
	public float scrollSpeed;
	Material backMaterial;

	public bool scroll = true; 

	private void Awake()
	{
        if(instance == null)
        {
            instance = this;
        }
		backMaterial = GetComponent<Renderer>().material;
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
    	if(scroll)
    	{
    		Vector2 offset = new Vector2(scrollSpeed * Time.time,0);
    		backMaterial.mainTextureOffset = offset;
    	}
    }
}
