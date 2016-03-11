using UnityEngine;
using System.Collections;

public class MovCamera : MonoBehaviour {
	public float factor=0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.W)) {
			transform.Translate(Vector3.forward*factor);
		}
		if (Input.GetKey(KeyCode.S)) {
			transform.Translate(Vector3.back*factor);
		}
		if (Input.GetKey(KeyCode.D)) {
			transform.Translate(Vector3.right*factor);
		}
		if (Input.GetKey(KeyCode.A)) {
			transform.Translate(Vector3.left*factor);
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.Rotate(Vector3.left);
		}
		if (Input.GetKey(KeyCode.DownArrow)) {
			transform.Rotate(Vector3.right);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Rotate(Vector3.up);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Rotate(Vector3.down);
		}
		if (Input.GetKey(KeyCode.R)) {
			transform.position= new Vector3(0f,1f,-22.5f);
			transform.TransformVector( Vector3.zero);
		}
	}


}
