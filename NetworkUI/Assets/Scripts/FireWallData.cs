using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
[CreateAssetMenu(menuName = "NetworkUI/FirewallData")]
public class FireWallData : ScriptableObject {

	public void ClearAll(){
		rawinputRules.Clear ();
		inputRules.Clear ();
		outputRules.Clear ();
		rawoutputRules.Clear ();
	}
		
	//an array of all the split parts
	public List<FRule> rawinputRules = new List<FRule>();
	public List<FRule> rawoutputRules = new List<FRule>();

	//list of the actual text to show
	public List<string> inputRules = new List<string>();
	public List<string> outputRules = new List<string>();

}
