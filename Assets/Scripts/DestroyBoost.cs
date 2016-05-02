using UnityEngine;
using System.Collections;

public class DestroyBoost : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void screenClear () {

		if (Time.timeScale > 0) {
			GameObject[] gameObjects = GameObject.FindGameObjectsWithTag ("Enemy");
			foreach (GameObject target in gameObjects) {
				GameObject.Destroy (target);
			}

			Destroy (GameObject.Find ("BugSpray"));
		}
	}
}
