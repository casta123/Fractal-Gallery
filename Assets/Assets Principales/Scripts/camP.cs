using UnityEngine;
using System.Collections;

public class camP : MonoBehaviour {
	public float factor=0.2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

			transform.Rotate(Vector3.up*factor);

	}
}
