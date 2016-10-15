using UnityEngine;
using System.Collections;

public class CharacterSkin : MonoBehaviour {

	public string name;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
