﻿using UnityEngine;
using System.Collections;

public class ControladorLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape)){ 
			Application.Quit();	                      
		} 
		if(Input.GetKey(KeyCode.R)){ 
			Application.LoadLevel("Escena1");			                      
		} 
	
	}
}
