using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	public static GameControl control;
	public string currentLevel;

	private bool allPapersFound = false;
	private bool dialogueDone = false;
	int level = 0;

	void Start () {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if (control != this){
			Destroy(gameObject);
		}

		control.allPapersFound = false;
		control.dialogueDone = false;
	}

	public void foundAllPapers()
	{
		allPapersFound = true;
		checkAndGo ();
	}

	public void dialogueFinished()
	{
		dialogueDone = true;
		checkAndGo ();
	}

	private void checkAndGo()
	{
		if (dialogueDone && allPapersFound) {
			level++;
			Application.LoadLevel(level);
			control.allPapersFound = false;
			control.dialogueDone = false;
		}
	}
}
