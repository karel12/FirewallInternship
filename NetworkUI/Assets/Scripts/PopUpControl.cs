using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PopUpControl : MonoBehaviour {
	private Animator myself;
	// Use this for initialization
	void Start () {
		myself = gameObject.GetComponent<Animator> ();
		
	}

	// Update is called once per frame
	void Update () {
		
	}
	public void PopUp(){
		//used to cover the other ones -> draw order
		transform.SetAsLastSibling ();
		myself.SetTrigger("Switch");


	}
}
