using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleChecker : MonoBehaviour {

	//public FireWallData check;
	public bool Check(FRule rule1,FRule rule2){
		if (rule1.chain == rule2.chain && rule1.ip == rule2.ip && rule1.port == rule2.port && rule1.policy.Equals (rule2.policy)) {
			return true;
		}
		return false;
	}

	//give it right and bad, if right comes before bad its all good 
	public bool LevelCheckInput(FRule goodRule,FRule badRule,FireWallData check){
		Stack<FRule> inputCopy = new Stack<FRule>();

		for (int i = 0; i < check.inputRules.Count; i++) {
			FRule x = check.rawinputRules[i];
		//	print (x.ToString ());
			inputCopy.Push (x);
		}
		//sanity check,dont run without any rules
		if (inputCopy.Count == 0) {
			return false;
		}	//flags for hitting good/bad
		bool good = false;
		bool bad = false;

		//if we are dealing with input

			//check all input rules
			for (int i = 0; i <= inputCopy.Count; i++) {
			//print ("i# in " + i.ToString());
				//make a local variable to avoid retyping
				FRule rule = inputCopy.Peek ();

				//look at the rule at the top of stack,if it matches the good rule
			if (Check(rule,goodRule)) {
					//if it matches, set good to true
					good = true;
				}
				//check the bad rule
			if (Check(rule,badRule)) {
					//if it matches, set good to true
					bad = true;
				}
				//MASTER CHECK IMPORTANT
				if (good && !bad) {
					return true;
				}
				if (bad && !good) {
					return false;
				}
				//pop the now checked rule
				inputCopy.Pop ();
			}

		// if we have not returned true by this point, the good rule doesnt exist
		return false;
	}
	//give it right and bad, if right comes before bad its all good 
	public bool LevelCheckOutput(FRule goodRule,FRule badRule,FireWallData check){
		//flags for hitting good/bad
		bool good = false;
		bool bad = false;

		//set up new queues/copies that we can pop from
		Stack<FRule> outputCopy = new Stack<FRule>();
		//check if there are actually any rules

		for (int i = 0; i < check.outputRules.Count; i++) {
			FRule x = check.rawoutputRules[i];
			//print ("push "+x.ToString ());
			outputCopy.Push (x);
		}

		if (outputCopy.Count == 0) {
			return false;
		}		//if we are dealing with input

		//check all input rules
		//print("cyclecount " + outputCopy.Count.ToString());
		for (int i = 0; i <= outputCopy.Count; i++) {
			//make a local variable to avoid retyping
			FRule rule = outputCopy.Peek ();
			//print ("currently checked rule "+rule.ToString ());
			//print ("currentlt against rule "+goodRule.ToString ());


			//look at the rule at the top of stack,if it matches the good rule
			if (Check(rule,goodRule)) {
				//if it matches, set good to true
				good = true;
			}
			//check the bad rule
			if (Check(rule,badRule)) {
				//if it matches, set good to true
				bad = true;
			}
			//MASTER CHECK IMPORTANT
			if (good && !bad) {
				return true;
			}
			if (bad && !good) {
				return false;
			}
			//pop the now checked rule
			outputCopy.Pop ();
		}

		// if we have not returned true by this point, the good rule doesnt exist
	//	print("not exist in");
		return false;
	}
		
}
