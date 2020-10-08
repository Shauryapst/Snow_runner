using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclespawner : MonoBehaviour
{

    public static obstaclespawner instance;

	public GameObject[] obstacles;
	public bool gameover;
    // Start is called before the first frame update

    public float minspawn;
    public float maxspawn;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn()
    {
    	float waittime = Random.Range(minspawn,maxspawn);
    	while(!gameover)
    	{
    		SpawnObstacle();
    		yield return new WaitForSeconds(waittime);
    	}
    }

    void SpawnObstacle()
    {
    	int random = Random.Range(0,obstacles.Length);
    	Instantiate(obstacles[random],transform.position,Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
