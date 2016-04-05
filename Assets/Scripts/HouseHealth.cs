using UnityEngine;
using System.Collections;

public class HouseHealth : MonoBehaviour {

	public int health = 1;

	// Do we need this? Consideration in case someone taps on the house
	public bool isEnemy = false;

	public void takeDamage(int damageVal)
	{
		health -= damageVal;

		if (health <= 0) {
			//Destroys the gameObject the script is attached to, in this case the house
			Destroy (gameObject);
		}
	}

	void Update() {

	}
}