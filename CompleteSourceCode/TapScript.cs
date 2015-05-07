using UnityEngine;
using System.Collections;

//TapScript module loads the screen on the Left mouse click or touch
public class TapScript : MonoBehaviour 
{
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButtonDown(0))
		{
			StartCoroutine (WaitDelay(1F));
			//load the Menu scene if a touch or left mouse click is observed

		}
	}
	//load the Menu scene if a touch or left mouse click is observed with the delay of waittime
	IEnumerator WaitDelay(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		Application.LoadLevel ("Menu1");
	}
}