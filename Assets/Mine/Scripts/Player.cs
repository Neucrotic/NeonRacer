using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{

    //Transform Data
	public Transform myTransform;

    //Speed Data
    float maxSpeed = 10;
    float minSpeed = 1;
    public float p_speed = 5;
    public Vector2 p_movement;
    int dirLR = 0;

    //Score Data
    public float score = 0;
    int scoreMultiplier = 1;

    void Start()
    {
        p_movement = new Vector2((float)dirLR, p_speed);
        myTransform = transform;
    }

	void Update ()
	{
        //ensuring speed stays within its range
        if (p_speed > maxSpeed)
        {
            p_speed = maxSpeed;
        }
        if (p_speed < minSpeed)
        {
            p_speed = minSpeed;
        }

        //detecting input for moving the player left and right
        if (Input.GetKey(KeyCode.A))
        {
            dirLR = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dirLR = 1;
        }

        //detecting input for adjusting the speed value
        if (Input.GetKey(KeyCode.W))
        {
            p_speed += Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            p_speed -= Time.deltaTime;
        }
		
        //increasing the score
        score += 1 * scoreMultiplier;
	}
}