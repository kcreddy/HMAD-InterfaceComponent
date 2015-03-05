using UnityEngine;

//HealthScript module loads the Menu of the first screen
public class HealthScript : MonoBehaviour
{
	public int hp = 1;
	public bool isEnemy = true;
    public GameObject explosion;
	public void Damage(int damageCount)
	{
		hp -= damageCount;
		if (hp <= 0)
		{
			// fade the gameobject from the scene 
			Destroy(gameObject);
		}
	}
	
	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
		if (shot != null)
		{
			if (shot.isEnemyShot != isEnemy)
			{
				Damage(shot.damage);
				Destroy(shot.gameObject); 
				Instantiate (explosion, transform.position, transform.rotation);
			}
		}
		Application.LoadLevel("TapScene");
	}
}