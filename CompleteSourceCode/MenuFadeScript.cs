using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuFadeScript : MonoBehaviour 
{
	public Canvas quitMenu;
	public Button startText;
	public Button exitText;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
	}

	//Exit the game
	public void ExitPress()
	{
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	
	}

	//Stay at the same level
	public void NoPress()
	{
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

	//Exit the game
	public void ExitLevel()
	{
		Application.Quit ();
	}

	//Load the Wave1 screen
	public void StartLevel()
	{
		Application.LoadLevel ("Wave1");
	}
}
