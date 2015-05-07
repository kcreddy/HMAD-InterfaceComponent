using UnityEngine;

// HealthScript module from the first screen
public class HealthScriptScene : MonoBehaviour
{
	// Defining the health count value 
	public int hp = 1;
	public bool isEnemy = true;

	// Defining the explosion prefab from the standard particles smoke prefabs
	// An added advantage of Unity id to have standard prefabs
	public GameObject explosion;

	public void Damage(int damageCount)
	{
		hp -= damageCount;
		if (hp <= 0)
		{
			// Destroy the gameobject from the scene 
			Destroy(gameObject);
			Instantiate (explosion, transform.position, transform.rotation);

			//Fade from Starting scene to next scene, in the game
			Application.LoadLevel("TapScene");
		}
	}

	void OnCollisionEnter (Collision col)
	{
		// Destroy gameobject from the scene, destroy it after collision
		Destroy (col.gameObject);

		// View multiple explosions after collisions from the imported stadard prefabs
		Instantiate (explosion, transform.position, transform.rotation);
		Instantiate (explosion, transform.position, transform.rotation);
		Instantiate (explosion, transform.position, transform.rotation);
		Instantiate (explosion, transform.position, transform.rotation);
		Instantiate (explosion, transform.position, transform.rotation);

		//Fade from Starting scene to next scene, in the game
		Application.LoadLevel("TapScene");
	}
}