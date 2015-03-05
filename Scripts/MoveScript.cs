using UnityEngine;

//MenuScript module 
public class MoveScript : MonoBehaviour
{
	//Defining the speed and direction for the movement
	public Vector2 speed = new Vector2(10, 10);
	public Vector2 direction = new Vector2(-1, 0);
	
	private Vector2 movement;

	// Update is called once per frame
	void Update()
	{
	//Calculating the movement with defined speed and direction
		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y);
	}

	//Enables the 2D GameObject to move with the calcumated movement
	void FixedUpdate()
	{
		rigidbody2D.velocity = movement;
	}
}