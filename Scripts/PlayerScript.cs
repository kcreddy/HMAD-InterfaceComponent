using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	// Update is called once per frame
	void Update()
	{
		bool shoot = Input.GetButtonDown("Fire1");
		shoot |= Input.GetButtonDown("Fire2");
		
		if (shoot)
		{
			WeaponScript weapon = GetComponent<WeaponScript>();
			if (weapon != null)
			{
				weapon.Attack(false);
			}
		}
	}
}