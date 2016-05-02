using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
    public static float prevSpeed = 2;
    private float speed;

    private Vector2 targetPos = new Vector2(0, 0);
    private Vector3 rotatePos = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start() {
        speed = prevSpeed;
    }
        void addSpeed()
    {
        if (PauseScript.speedup > 1.0f && prevSpeed <=11)
        {
            PauseScript.speedup = 0;
            prevSpeed += 0.1f;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
        addSpeed();
        if (speed !=0)

        if (Time.timeScale == 0.5F)
            {
                // Move mosquito towards the House's point at 0,0
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), targetPos, Time.fixedDeltaTime * speed / 2);

                // Rotate the sprite's image to face the house
                Vector3 houseDir = rotatePos - transform.position;
                float angle = Mathf.Atan2(houseDir.y, houseDir.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis((angle - 90), Vector3.forward);

            }
        else if (Time.timeScale == 0)
        {
            // Move mosquito towards the House's point at 0,0
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), targetPos, 0);

            // Rotate the sprite's image to face the house
            Vector3 houseDir = rotatePos - transform.position;
            float angle = Mathf.Atan2(houseDir.y, houseDir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis((angle - 90), Vector3.forward);

        }

        else
        {
                // Move mosquito towards the House's point at 0,0
                transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), targetPos, Time.fixedDeltaTime * speed);

                // Rotate the sprite's image to face the house
                Vector3 houseDir = rotatePos - transform.position;
                float angle = Mathf.Atan2(houseDir.y, houseDir.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis((angle - 90), Vector3.forward);
            }

     
    }
}