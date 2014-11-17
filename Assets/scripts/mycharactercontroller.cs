using UnityEngine;
using System.Collections;

public class mycharactercontroller : MonoBehaviour { 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = Vector3.zero;

		// is up pressed?
		if (Input.GetKey (KeyCode.UpArrow) == true) {
			// move character up by some amount
			direction.y += 0.1f;
		}
		// is left pressed?
		if (Input.GetKey (KeyCode.LeftArrow) == true) {
			// move character up by some amount
			direction.x -= 0.1f;
		}
		// is right pressed?
		if (Input.GetKey (KeyCode.RightArrow) == true) {
			// move character right by some amount
			direction.x += 0.1f;
		}
		// is down pressed?
		if (Input.GetKey (KeyCode.DownArrow) == true) {
			// move character down by some amount
			direction.y -= 0.1f;
		}

		gameObject.transform.Translate (direction);

	}
}
