using UnityEngine;
using System.Collections;

public class chaos : MonoBehaviour {

	Rigidbody r;

	// Use this for initialization
	void Start () {
		r = GetComponent<Rigidbody> ();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			r.AddForce(Vector3.right*700f);
		}
	}
}
