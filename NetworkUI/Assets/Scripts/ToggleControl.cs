using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ToggleControl : MonoBehaviour {
	//the firewall that we want to add rules to
	public FireWall firewall;

	/*
	 * rule style: -A chain/rule[0] -d ip/rule[1] --dport port/rule[2] -j policy/rule[3]
	 * Four toggle groups:
	 * chain - rule[0]
	 * ip - rule[1]
	 * port -rule[2]
	 * policy - rule[3]
	 * 
	 * 
	 * */
	public ToggleGroup chain;
	public ToggleGroup ip;
	public ToggleGroup port;
	public ToggleGroup policy;
	// Use this for initialization

	
	public void GetChain(FRule rule){
		//check if any are on
		if (chain.AnyTogglesOn()) {
			//if so,only one can be on, so get it
			Toggle activeToggle = chain.ActiveToggles().First();
			rule.chain = (activeToggle.GetComponentInChildren<Text> ().text);
			
		}
		else {rule.chain =("X");}
	
	}
	public void GetIP(FRule rule){
		//check if any are on
		if (ip.AnyTogglesOn()) {
			//if so,only one can be on, so get it
			Toggle activeToggle = ip.ActiveToggles().First();
			rule.ip = (activeToggle.GetComponentInChildren<Text> ().text);

		}
		else {rule.ip =("X");}

	}
	public void GetPort(FRule rule){
		//check if any are on
		if (port.AnyTogglesOn()) {
			//if so,only one can be on, so get it
			Toggle activeToggle = port.ActiveToggles().First();
				//for ranges set it to 2001
			if (activeToggle.GetComponentInChildren<Text> ().text.Contains (":")) {
				rule.port = 2001;
			} 
			else {
				rule.port = int.Parse ((activeToggle.GetComponentInChildren<Text> ().text));
			}

		}
		else {rule.port = 0;}

	}
	public void GetPolicy(FRule rule){
		//check if any are on
		if (policy.AnyTogglesOn()) {
			//if so,only one can be on, so get it
			Toggle activeToggle = policy.ActiveToggles().First();
			rule.policy = (activeToggle.GetComponentInChildren<Text> ().text);

		}
		else {rule.policy =("X");}

	}
	public void Submit(){
		
		//make the rule
		FRule newRule = new FRule("","",0,"");
		GetChain (newRule);
		GetIP (newRule);
		GetPort (newRule);
		GetPolicy (newRule);
		//add the rule
		firewall.AddRule(newRule);
		//data.RefreshRules ();

	}
	public void RemoveOutputRule()
	{
		firewall.RemoveOut();
		
	}
	public void RemoveInputRule()
	{
		firewall.RemoveIn();

	}
}
