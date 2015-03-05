using UnityEngine;
using System.Collections;

//MenuScript module loads the Menu of the first screen 
public class MenuScript : MonoBehaviour {

	// OnGUI function to load the Button Menus
	void OnGUI()
	{
		//Game control ot the First Level of the Game
		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height / 8, Screen.width / 5, Screen.height / 10), "Start Mission")) 
		{
			Application.LoadLevel ("Wave1Scene");
		}

		//  Implement  'Help' to guide the palyer wht the game is
		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height / 4, Screen.width / 5, Screen.height / 10), "Help")) 
		{
			Application.LoadLevel ("Wave1Scene");
		}

		// Give the game an option to exit at this point
		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height / 2.7f, Screen.width / 5, Screen.height / 10), "Exit Mission")) 
		{
			Application.Quit();
		}
	}
}



