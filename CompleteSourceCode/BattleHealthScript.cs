using UnityEngine;
using System.Collections;

public class BattleHealthScript : MonoBehaviour {
	public int healthprobable = 1;
	public bool isEnemy = true;
	public void Damage(int damageCount)
	{
		healthprobable -= damageCount;
		if (healthprobable <= 0)
		{
			//Destroy the game object
			Destroy(gameObject);
		}
	}
	// On collision detection
	void OnCollisionEnter (Collision col)
	{
		ShootingScript shooting = col.gameObject.GetComponent<ShootingScript>();
		if (shooting != null)
		{
			if (shooting.isEnemyShot != isEnemy)
			{
				// Destroy the game object in hte scene
				Damage(shooting.damage);
				Destroy(shooting.gameObject); 
				//Fade to next scene, in the game
				Application.LoadLevel("GameOver");
			}
		}
	}
}