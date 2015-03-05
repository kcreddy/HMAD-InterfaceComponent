using UnityEngine;

public class ShotScript : MonoBehaviour
{
	public int damage = 1;
	public bool isEnemyShot = false;
	public GameObject explosion;
	void Start()
	{

		Destroy(gameObject, 20); 
		Instantiate (explosion, transform.position, transform.rotation);

	}
}