using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {
   
	private int health = 1;
	private int damage = 1;
    GameObject currentMosquito;

	void takeDamage(int damageVal)
	{
        if (Time.timeScale != 0)
        {
            health -= damageVal;
        }
	}

	void Update() {

       
        

		RaycastHit2D rayHit;

		// Current position of our object
		Vector3 currentPos = transform.position;

		// If there's a touch or left-click
		if (Input.GetMouseButtonDown (0)) {
			
			// Spawn a raycast that pinpoints where the touch was
			rayHit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);

			// If there's a collider that is hit and the object detected has an Enemy tag
			if (rayHit.collider != null && rayHit.transform.gameObject.tag == "Enemy") {
				// Assign the specific gameObject detected to currentMosquito
				currentMosquito = rayHit.collider.gameObject;

				// Get the EnemyHealth script of the specific mosquito and decrement its health
				// Weird issue when health is more than 1, needs to be looked at
				this.GetComponent<AudioSource>().Play(); 
				rayHit.transform.gameObject.GetComponent<EnemyHealth>().takeDamage(1);

				if (health <= 0) {
                    // Destroys the gameObject the script is attached to, in this case the mosquito
                    Score.SCORE++;
					Destroy (currentMosquito);
				}
			}
		}
	}
}