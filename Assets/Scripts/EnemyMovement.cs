using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float speed = 2;

	private Rigidbody2D body;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		// For diagonal movement, add to Vector2's: ex: (Vector2.left + Vector2.right) * speed
			GetComponent<Rigidbody2D> ().velocity = Vector2.left * speed;
	}

}