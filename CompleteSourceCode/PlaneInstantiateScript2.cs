using UnityEngine;
using System.Collections;
// PlaneInstantiateScript2 to instantiate the plane object in the waves
public class PlaneInstantiateScript2 : MonoBehaviour {
	public Rigidbody planePrefab;
	// Use this for initialization
	void Start () {
		//Plane creation script to create the planes at the defined coordinate locations
		StartCoroutine (PlaneCreation(0.5F));
	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Plane_1")
		{
			// Destroy the game object
			Destroy(col.gameObject);
		}
	}
	//Randomized plane creation at the coordinate location with the waittime
	IEnumerator PlaneCreation(float waitTime){
		for (int y = 2; y < 5; y++) {
			for (int x = 31; x < 40; x++) {
				Instantiate(planePrefab, new Vector3(x+1, y+1, 10), Quaternion.identity);
				yield return new WaitForSeconds(waitTime);
				Instantiate(planePrefab, new Vector3(x+2, y+2, 10), Quaternion.identity);
				yield return new WaitForSeconds(waitTime);
				Instantiate(planePrefab, new Vector3(x, y, 10), Quaternion.identity);
				yield return new WaitForSeconds(waitTime);
				Instantiate(planePrefab, new Vector3(x-2, y-2, 10), Quaternion.identity);
				yield return new WaitForSeconds(waitTime);
				Instantiate(planePrefab, new Vector3(x-1, y-1, 10), Quaternion.identity);
				yield return new WaitForSeconds(waitTime);
			}
		}
	}
	
}
