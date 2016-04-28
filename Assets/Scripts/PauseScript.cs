using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour {
    public bool paused;
    public GameObject menu;
    public Button stopButton;
    public float timer = 0.0F;
    public bool pausable = false;
    private float fillbutton;
    // Use this for initialization
    void Start () {
        paused = false;
        Time.timeScale = 1;
        menu.SetActive(paused);
        fillbutton = 0;
    }
	
	// Update is called once per frame
	void Update () {

        fillbutton += Time.deltaTime / 2.5f;
        timer += Time.deltaTime;
        stopButton.image.fillAmount = fillbutton;

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
        

        if (Time.timeScale == 1 && pausable == true) { 
            Time.timeScale = 0.5F;
            fillbutton = 0;
            
        }





    }
}
