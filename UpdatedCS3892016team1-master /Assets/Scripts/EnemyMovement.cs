using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	private float speed = 2;
	private Vector2 targetPos = new Vector2(0,0);
	private Vector3 rotatePos = new Vector3(0,0,0);

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
		// Move mosquito towards the House's point at 0,0
		transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), targetPos, Time.fixedDeltaTime*speed);

		// Rotate the sprite's image to face the house
		Vector3 houseDir = rotatePos - transform.position;
		float angle = Mathf.Atan2 (houseDir.y, houseDir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis ((angle-90), Vector3.forward);
	}

}