using UnityEngine;
using System.Collections;

public class WalkingLogic : MonoBehaviour {

	public float speed;
	public GameObject label;
	new public string name;
	protected Rigidbody2D body;
	int dir = 1;

	// Use this for initialization
	protected virtual void Start () {
		body = GetComponent<Rigidbody2D> (); 
		if (label != null) {
			label.GetComponent<TextMesh> ().text = name;
		}
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		transform.position = transform.position + new Vector3 (dir * speed * Time.deltaTime, 0, 0);
	}

	protected virtual void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Switch" || coll.gameObject.tag == "Enemy")
		{
			if (transform.position.y <= coll.gameObject.transform.position.y + 1)
			{
				dir = -dir;
				transform.Rotate(0, 180, 0);
				if(label != null)
				{
					label.transform.Rotate(0, 180, 0);
				}
			}
		}
	}
}
