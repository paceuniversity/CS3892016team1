using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	// Create an index in the case of multiple enemy types
	public GameObject[] enemyArray;

	// Use this for initialization
	void Start () {

		// Start time before a spawner begins spawning
		float spawnStart = Random.Range (1, 7);

		// Call the spawner method at the randomly created starting time
		Invoke ("Spawn", spawnStart);
	}

	void Spawn() {

		// Randomized spawn delay from 1 to 5 seconds
		float spawnDelay = Random.Range(1, 5);

		// Choose a random enemy from our array to spawn
		int enemyIndex = Random.Range (0, enemyArray.Length);

		// Create our enemies put into the array
		Instantiate (enemyArray [enemyIndex], transform.position, transform.rotation);
		// Call the spawn method to continue spawning
		Invoke ("Spawn", spawnDelay);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
