using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestMarkupColour : MonoBehaviour {
	public Text text;
	public void testMarkup(){
		string a = "";

		a += "<color=red> thisis</color>";
		a += "<color=green> working?</color>";
		text.text = a;

	}
}
