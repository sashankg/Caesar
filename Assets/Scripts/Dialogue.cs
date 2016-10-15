using UnityEngine;
using System.Collections;

public class Dialogue : MonoBehaviour {

	public string[] str;
	public int delay = 100;
	int index = 0;
	TextMesh text;
	// Use this for initialization
	void Start () {
		 text = GetComponent<TextMesh> ();
		text.text = str [index];
	}
	
	// Update is called once per frame
	void Update () {
		if (delay < 0) {
			if(index < str.Length-1)
			{
				index++;
				text.text = str [index];
			}
			else
			{
				GameControl.control.dialogueFinished();
			}
			delay = 100;
		} else {
			delay--;
		}
	}
}
