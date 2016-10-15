using UnityEngine;
using System.Collections;

public class ReturnToLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void retryLevel()
	{
		Debug.Log (GameControl.control.currentLevel);
		Application.LoadLevel (GameControl.control.currentLevel);
	}
}
