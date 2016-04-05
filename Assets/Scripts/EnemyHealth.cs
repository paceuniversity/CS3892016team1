﻿using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int health = 1;
	public int damage = 1;

	// Do we need this? Consideration in case someone taps on the house
	public bool isEnemy = true;

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