using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int health = 1;
	public int damage = 1;

	public void takeDamage(int damageVal)
	{
		health -= damageVal;

		if (health <= 0) {
			//Destroys the gameObject the script is attached to, in this case the mosquito
			Destroy (gameObject);
		}
	}

	void Update() {

	}
}