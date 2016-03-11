using UnityEngine;
using System.Collections;

public class salida : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		Application.LoadLevel("Lorenz");
	}

}
