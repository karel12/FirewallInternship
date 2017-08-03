using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PCData : MonoBehaviour {

	public string id = "pc";
	public string IPadress;
	public GameObject panel;	// Use this for initialization
	public Text ip;
	public Text servicesRunning;
	public Controller control;
	public  Service[] services; 

	void Start () {
		
	}

	public string GetServicesAsString(){
		string allServices = "";
		foreach ( Service a in services) {
			allServices += a.GetServiceAsString();
		}
		
		return allServices;
	}
	public void startPanel(){
		ip.text = "The IP adress of this PC is: " + IPadress;
		servicesRunning.text ="Services running on this PC \n"+ GetServicesAsString ();
		control.OnClickPC (panel);
	
	}

}
