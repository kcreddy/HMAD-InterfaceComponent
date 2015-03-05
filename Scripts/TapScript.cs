using UnityEngine;
using System.Collections;

//TapScript module loads the screen on the Left mouse click or touch


public class TapScript : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			//load the Menu scene if a touch or left mouse click is observed
			Application.LoadLevel ("MenuScene");
		}
	}
}