using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
	public static manager instance; 

	public GameObject gameOverPanel;

    public Text score;
    int scorelol = 0;

    

	private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
    	obstaclespawner.instance.gameover = true;

    	gameOverPanel.SetActive(true);


    	backScroll[] background = FindObjectsOfType<backScroll>();
    	foreach(backScroll t in background)
    	{
    		t.scroll = false;
    	}
    }

    public void Restart()
    {
    	SceneManager.LoadScene("Game");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MENU");
    }

    public void incrementScore()
    {
        scorelol++;
        score.text = scorelol.ToString();
    }



}
