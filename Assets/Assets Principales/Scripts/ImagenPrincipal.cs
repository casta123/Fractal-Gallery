using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImagenPrincipal : MonoBehaviour {
	public Sprite[] OtherSprite;
	
	/// <summary>
	/// The Array of Images.
	/// </summary>
	Image[] images;
	int i=0;
	// Use this for initialization
	void Start () {
		images = gameObject.GetComponentsInChildren<Image>();
		// Loop through each image and set it's Sprite to the other Sprite.

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			foreach (Image image in images) {
				image.sprite = OtherSprite [i];
			}
			if(i<OtherSprite.Length-1)
				i++;
			else
				i=0;
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			foreach (Image image in images) {
				image.sprite = OtherSprite [i];
			}
			if(i>0)
				i--;
			else
				i=OtherSprite.Length-1;
		}
	
	}
}
