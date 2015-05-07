using UnityEngine;

public class HealthScript : MonoBehaviour
{
	public int hp = 1;
	private static int score = 0 ;
	public bool isEnemy = true;
	public GameObject explosion;
	public GUIText guiScore;

	//View the score of the game in the screen
	void start(){
		guiScore.text = "Score:"+score;
	}

	public void Damage(int damageCount)
	{
		hp -= damageCount;
		
		if (hp <= 0)
		{
			// Destroy the game object in hte scene
			Destroy(gameObject);
			// Initiate the explosion after the game object is destroyed in hte game scene
			Instantiate (explosion, transform.position, transform.rotation);
		}
	}
	// On dectection of the collision
	void OnCollisionEnter (Collision col)
	{
			ShotScript shot = col.gameObject.GetComponent<ShotScript>();
			if (shot != null)
			{
				if (shot.isEnemyShot != isEnemy)
				{
				    // Destroy the game object in hte scene
					Damage(shot.damage);
					Destroy(shot.gameObject); 
				    // Initiate the explosion after the game object is destroyed in hte game scene
					Instantiate (explosion, transform.position, transform.rotation);
					// Add the score after destroying the game objects
					score+=10;
					guiScore.text = "Score: "+score;
				if(score%100==0)
				{
					//Fade to next scene, in the game
					Application.LoadLevel("Menu2");
				}

			    }
			}
	}
}