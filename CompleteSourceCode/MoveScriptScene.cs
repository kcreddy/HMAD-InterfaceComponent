using UnityEngine;

//MoveScriptScene module from the first scene
public class MoveScriptScene : MonoBehaviour
{
	private Vector2 movement;

	//Defining the speed and direction for the movement of the plani in startting scene
	public Vector2 speed = new Vector2(10, 10);
	public Vector2 direction = new Vector2(-1, 0);


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
		rigidbody.velocity = movement;
	}
}