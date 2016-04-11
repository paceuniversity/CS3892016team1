using UnityEngine;
using System.Collections;

public class House : MonoBehaviour {

	public int health = 1;

	public void takeDamage(int damageVal)
	{
		health -= damageVal;

		if (health <= 0) {
			//Destroys the gameObject the script is attached to, in this case the house
			Destroy (gameObject);
            Application.LoadLevel("GameOver");
		}
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			takeDamage (1);
		}
	}
}