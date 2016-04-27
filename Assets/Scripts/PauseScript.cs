using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
    public bool paused;
    public GameObject menu;
    public float timer = 0.0F;
    public bool pausable = false;
    // Use this for initialization
    void Start () {
        paused = false;
        Time.timeScale = 1;
        menu.SetActive(paused);
    }
	
	// Update is called once per frame
	void Update () {
       

        timer += Time.deltaTime;

        if (timer > 1.5F && pausable == true)
        {
            pausable = false;
            Time.timeScale = 1;
            timer = 0;

        }
        if (timer > 2.5F)
        {
            pausable = true;
            timer = 0;
        }
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

    public void slowTime()
    {
        

        if (Time.timeScale == 1 && pausable == true)
            Time.timeScale = 0.5F;





    }
}
