using UnityEngine;
using System.Collections;

public class Rossler : MonoBehaviour {

	/* Los valores A,B y C son paramtros que la ecuaciones las cuales al ser cambiadas
	asi sea poco se ve relfejado un gran cambio*/
	public float a=0.1f,b=0.1f,c=7f;
	public string text="";
	// Use this for initialization
	void Start () {
		transform.position = new Vector3(10f,10f,10f);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 aux = transform.position;
		// Estas posiciones que se definen con respectoa las ecuaciones diferenciales que plantea Lorenz 
		float posx = (-aux.y - aux.z);
		float posy = aux.x + a*aux.y;
		float posz = b + (aux.x - c)* aux.z;
		transform.position +=(new Vector3(posx, posy, posz))* Time.deltaTime;
		
	}

	void OnGUI () {
		GUI.Label (new Rect (50,Screen.height*5/6,Screen.width*3/4,Screen.height/3), text);
	}
}