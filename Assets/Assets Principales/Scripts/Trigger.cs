using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {
	public string text="";
	public string textB="";
	public Texture2D icon;
	private Texture2D iconv;


	void OnTriggerEnter(Collider other){
		text = textB;

	}
	void OnTriggerStay(Collider other){
		text = textB;
	}
	void OnTriggerExit(Collider other){
		text = "";

	}

	void OnGUI () {

		GUI.Label (new Rect (50,Screen.height*4.5f/6,Screen.width*3/4,Screen.height/3), text);
	}
}
