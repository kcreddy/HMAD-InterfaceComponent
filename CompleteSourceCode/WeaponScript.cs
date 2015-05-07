using UnityEngine;
using System.Collections;
// Weapon script module defining and moving missile
public class WeaponScript : MonoBehaviour
{
	public Rigidbody shoPrefab;
	public float speed = 1f;
	private float power = 2;
	private Vector3 target;
	private MissileMovement missileMove;
	private float startTime;

	void Start()
	{
		target = transform.position;
		startTime = Time.time;
	}
	// Move the missile to the click position at the waittime delay
	void Update()
	{
	//transform.position.y = target - 4.905 * (Time.time - startTime) * (Time.time - startTime);
	if (Input.GetMouseButtonDown (0)) {
			StartCoroutine (MissileCreation(0.001F));		
		}
	}
	//Move the missile at the position and add force so that it moves in the 
	//parabolic motion until the click position is reached

	IEnumerator MissileCreation(float waitTime){
		    //var temp = 4.905 * (startTime) * (Time.time);
			var shotTransform = Instantiate (shoPrefab, new Vector3 (0, -2, 10), Quaternion.identity) as Rigidbody;
			shotTransform.rigidbody.AddForce (GetForceFrom (shotTransform.position, Camera.main.ScreenToWorldPoint (Input.mousePosition)), ForceMode.Impulse);
			target = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			target.z = shotTransform.position.z;
			while (target!=shotTransform.position && !shotTransform.detectCollisions)
			{
			Debug.Log(shotTransform.detectCollisions);
			yield return new WaitForSeconds(waitTime);
			//Vector3 vel = GetForceFrom(shotTransform.transform.position,Camera.main.ScreenToWorldPoint(Input.mousePosition));
			//shotTransform.velocity = (target - shotTransform.position).normalized * speed ;
			//float angle = Mathf.Atan2(vel.y,vel.x)* Mathf.Rad2Deg;
			//shotTransform.rotation = Quaternion.Euler(new Vector3(0,0,0));
			shotTransform.position = Vector3.MoveTowards (shotTransform.position, target, speed * Time.deltaTime);   
			}				
}
	private Vector2 GetForceFrom(Vector3 fromPos, Vector3 toPos)
	{
		return (new Vector2(toPos.x, toPos.y) - new Vector2(fromPos.x, fromPos.y))*power;
	}

	public void Attack(bool isEnemy)
	{
	}
}