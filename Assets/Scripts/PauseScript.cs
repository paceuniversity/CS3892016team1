using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
    public bool paused;
    public GameObject menu;
	// Use this for initialization
	void Start () {
        paused = false;
        Time.timeScale = 1;
        menu.SetActive(paused);
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void pause()
    {
        
            paused = !paused;
        
        if (paused)
        {
            Time.timeScale = 0;
            menu.SetActive(paused);

        }
        else if (!paused)
        {
            Time.timeScale = 1;
            menu.SetActive(paused);
        }
    }
}
