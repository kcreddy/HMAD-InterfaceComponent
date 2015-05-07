using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {
	public int damage = 1;
	public bool isEnemyShot = false;
	
	void Start()
	{
		// Destroy the game object in the scene
		Destroy(gameObject, 20); 
	}
}