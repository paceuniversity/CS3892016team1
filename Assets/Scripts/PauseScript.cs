using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour {
    public bool paused;
    public GameObject menu;
    public Button stopButton;
    public float timer = 0.0F;
    public float timer2 = 0.0F;
    public static float speedup = 0;
    public static bool pausable = false;
    private float fillbutton;
    // Use this for initialization
    void Start () {
        EnemyMovement.prevSpeed = 2;
        paused = false;
        Time.timeScale = 1;
        menu.SetActive(paused);
        fillbutton = 0;
    }
	
	// Update is called once per frame
	void Update () {
        speedup += Time.deltaTime;
        fillbutton += Time.deltaTime / 7.0f;
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        stopButton.image.fillAmount = fillbutton;

        if (timer2 > 1.5F && pausable == true)
        {
            pausable = false;
            Time.timeScale = 1;
            timer = 0;
            

        }
        if (timer > 5.5F)
        {
            pausable = true;
            
            timer2 = 0;
            
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
        

        if (Time.timeScale == 1 && timer > 5.5F) { 
            Time.timeScale = 0.5F;
            fillbutton = 0;
            timer = 0;

        }





    }
}
