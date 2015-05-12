using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{

    //Transform Data
	public Transform myTransform;

    //Speed Data
    public float maxSpeed = 10;
    public float minSpeed = 1;
    public float speed = 5;
    float moveSpeed = 15;

    //Score Data
    public float score = 0;

    void Start()
    {
        myTransform = transform;
    }

    void FixedUpdate()
    {
        //detecting input for moving the player left and right
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = new Vector3(this.transform.position.x - moveSpeed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position = new Vector3(this.transform.position.x + moveSpeed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        }
    }

	void Update ()
	{
        //ensuring speed stays within its range
        if(speed > maxSpeed)
        {
            speed = maxSpeed;
        }
        if (speed < minSpeed)
        {
            speed = minSpeed;
        }

        //detecting input for adjusting the speed value
        if (Input.GetKey(KeyCode.W))
        {
            speed += Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            speed -= Time.deltaTime;
        }
		
        //increasing the score
        score++;

        Debug.Log(score.ToString());
	}
}