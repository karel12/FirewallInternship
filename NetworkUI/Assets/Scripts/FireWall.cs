using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireWall : MonoBehaviour {
	public FireWallData data;
	public Controller control;
	public GameObject panel;
	public GameObject rulePanel;

	FireWall thisObject;

	public Text input;
	public Text output;

	public void Awake(){
		
		thisObject = gameObject.GetComponent<FireWall> ();
	}
	public void StartPanel(){
		RefreshRules ();

		control.OnClickFirewall(panel,rulePanel,thisObject);

	}
	public void AddRule(FRule rule){
		//create the rule in right syntax
		string ruleAsText;



		if(rule.chain =="OUTPUT") {
			rule.number = data.outputRules.Count;
			data.rawoutputRules.Add (rule);
			ruleAsText = rule.ToString();
			data.outputRules.Add (ruleAsText);

		}
		else {
			//get the raw data,then process and get the nice text

			rule.number = data.inputRules.Count;
			data.rawinputRules.Add (rule);
			ruleAsText = rule.ToString ();
			data.inputRules.Add (ruleAsText);


		}
		RefreshRules ();

	
	}
	public void RefreshRules(){

		// make the input/output lists into a string with newline between items
		string inputRulesAsText = string.Join ("\n" , data.inputRules.ToArray ());
		string outputRulesAsText = string.Join ("\n" , data.outputRules.ToArray ());


			//display the resulting strings
		input.text = inputRulesAsText;
		output.text = outputRulesAsText;


	}
	public void RemoveOut(){
		
		print("remove out");
		data.outputRules.RemoveAt(data.outputRules.Count-1);
		data.rawoutputRules.RemoveAt(data.rawoutputRules.Count-1);
		RefreshRules ();
	}
	public void RemoveIn(){
		print("remove in");

		data.inputRules.RemoveAt(data.inputRules.Count-1);
		data.rawinputRules.RemoveAt(data.rawinputRules.Count-1);
		RefreshRules ();
	}
		
}
