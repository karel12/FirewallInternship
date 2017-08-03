using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelAnimation : MonoBehaviour {
	/*
	Just a small script to get the picture animated
	*/
	public Sprite[] sprites;
	public float frameRate;
	public Image image;

	// Use this for initialization
	void Start () {
		image = GetComponent<Image> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		int index = (int)(Time.time * frameRate) % sprites.Length;

		image.sprite = sprites[index];

	}
}
