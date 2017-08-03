using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IDS : MonoBehaviour {
	[TextArea]
	public string logText;
	public Text log;

	public Controller control;
	public GameObject panelLeft;
	public GameObject panelRight;
	// Use this for initialization

	void Awake () {
		//try to get it assigned automatically !TEST!

		log.text = logText;
	}

	public void StartPanel(){
		control.OnClickIDS (panelLeft, panelRight);	
	
	}
		
}
