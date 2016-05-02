using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class House : MonoBehaviour {

	private int health = 10000;
    public Slider healthSlider;
    public float sliderValue;
    public int initalHealth = 0;

    
    public void takeDamage(int damageVal)
	{
        sliderValue += damageVal /10.0f;
		health -= damageVal;

        healthSlider.value = sliderValue;
        if (health <= 0) {
			// Destroys the gameObject the script is attached to, in this case the house
			Destroy (gameObject);
            Application.LoadLevel("GameOver");
		}
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			takeDamage (1);
			Destroy (col.gameObject);
		}
	}
}