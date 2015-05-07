using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour
{
	Sprite[] frames;
	int framesPerSecond = 25;
	SpriteRenderer rend;
	private string[] names;
	// Use this for initialization
	void Start ()
	{
		// loading the images 
		frames = Resources.LoadAll<Sprite>("Texture");
		rend = GetComponent<SpriteRenderer>();
		names = new string[frames.Length];
		// running them through loop
		for(int i = 0; i < names.Length; i++) 
		{
			names[i] = frames[i].name;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		int index = (int)((Time.time * framesPerSecond) % frames.Length);
		rend.sprite = frames[index];
	}
}

