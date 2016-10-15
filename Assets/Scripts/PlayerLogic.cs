using UnityEngine;
using System.Collections;

public class PlayerLogic : WalkingLogic{

	public int papers;
	Animator anim;

	// Use this for initialization
	override protected void Start () {
		GameControl.control.currentLevel = Application.loadedLevelName;
		Time.timeScale = 1;
		base.Start ();
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	override protected void Update () {
		base.Update ();
		if((Input.GetButtonDown("Jump") || Input.GetMouseButton(0)) && body.velocity.y == 0)
		{
			anim.SetTrigger("Jump");
			body.AddForce(new Vector2(0, 450), ForceMode2D.Force);
		}
		if (body.velocity.y < -0.1f) {
			anim.SetBool ("isFalling", true);
		} else {
			anim.SetBool("isFalling", false);
		}
	}

	override protected void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log(coll.gameObject.tag);
		if (coll.gameObject.tag == "Enemy")
		{
			Time.timeScale = 0;
			Application.LoadLevel("You Lose");
		}
		if (coll.gameObject.tag == "Paper") {
			Destroy(coll.gameObject);
			papers--;
			if(papers == 0)
			{
				GameControl.control.foundAllPapers();

			}
		}
		base.OnCollisionEnter2D (coll);
	}
}
