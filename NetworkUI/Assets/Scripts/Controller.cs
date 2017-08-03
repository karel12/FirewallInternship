using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Controller : MonoBehaviour {
	public GameObject currentLeftPanel;
	public GameObject currentRightPanel;

	public GameObject defaultLeftPanel;
	public GameObject defaultRightPanel;

	public FireWallData data;
	public FireWallData innerData;
	public FireWallData outerData;

	public GameObject finalScreen;
	public RuleChecker checker;

	public LevelControl levelControl;

	public int levelNumber;
	private bool levelComplete = false;

	/*
	 * New style where eqch button has its own function
	 * 
	 * */
	public void Awake(){
		checker = gameObject.GetComponent<RuleChecker> ();
		//clear all firewall data on every awake, a failsafe
		innerData.ClearAll();
		outerData.ClearAll();

	}
	public void OnClickFirewall(GameObject panelLeft,GameObject panelRight,FireWall firewall){
		this.data = data;
		currentLeftPanel.SetActive (false);
		currentLeftPanel = panelLeft;
		currentLeftPanel.SetActive (true);

		currentRightPanel.SetActive (false);
		currentRightPanel = panelRight;
		currentRightPanel.SetActive (true);


		//set the right firewall for rules management
		ToggleControl currentToggleControl = currentRightPanel.GetComponentInChildren<ToggleControl> ();
		currentToggleControl.firewall = firewall;

	}

	public void OnClickPC(GameObject panelLeft){

		currentLeftPanel.SetActive (false);
		currentLeftPanel = panelLeft;
		currentLeftPanel.SetActive (true);

		currentRightPanel.SetActive (false);
		currentRightPanel = defaultRightPanel;
		currentRightPanel.SetActive (true);
	}

	public void OnClickIDS(GameObject panelLeft,GameObject panelRight){

		currentLeftPanel.SetActive (false);
		currentLeftPanel = panelLeft;
		currentLeftPanel.SetActive (true);

		currentRightPanel.SetActive (false);
		currentRightPanel = defaultRightPanel;
		currentRightPanel.SetActive (true);
	}
	public string GenerateFeedback(List<FRule> rightin ,List<FRule> wrongin, List<FRule> rightout,List<FRule> wrongout,FireWallData inner, FireWallData outer){
		string feedback = "";
		//make a new list and copy values in
		List<FRule> allInnerRules = new List<FRule> ();	
		foreach (var rule in inner.rawinputRules) {
			allInnerRules.Add (rule);
		}
		foreach (var rule in inner.rawoutputRules) {
			allInnerRules.Add (rule);
		}

		List<FRule> allOuterRules = new List<FRule> ();
		foreach (var rule in outer.rawinputRules) {
			allOuterRules.Add (rule);
		}
		foreach (var rule in outer.rawoutputRules) {
			allOuterRules.Add (rule);
		}

		feedback += "Inner\n";
		foreach (var rule in allInnerRules) {
			if (CompareAgainstAList(rule,rightin)) {
				feedback += "<color=green><size=12>" + rule.FeedbackString () + "</size></color>\n";
			} else if (CompareAgainstAList(rule,wrongin)) {
				feedback += "<color=red><size=12>" + rule.FeedbackString() + "</size></color>\n";
			}
			else {
				feedback += "<color=yellow><size=12>" + rule.FeedbackString() + "</size></color>\n";

			}
		}
		feedback += "\nOuter\n";

		foreach (var rule in allOuterRules) {
			if (CompareAgainstAList(rule,rightout)) {
				feedback += "<color=green><size=12>" + rule.FeedbackString() + "</size></color>\n";
			} else if (CompareAgainstAList(rule,wrongout)) {
				feedback += "<color=red><size=12>" + rule.FeedbackString() + "</size></color>\n";
			}
			else {
				feedback += "<color=yellow><size=12>" + rule.FeedbackString() + "</size></color>\n";

			}
		}

		return feedback;
	
	}
	//helper function for generateFeedback, to test if a rule is in a list
	public bool CompareAgainstAList(FRule testRule, List<FRule> compareList){
		bool isIn = false;

		for(int i = 0;i< compareList.Count;i++){
			
			if ( checker.Check(testRule, compareList[i]) ) {
				isIn = true;
			}
			else {
				continue;
			}
		}

		return isIn;
	
	}
	//write out all the rules,with colour depending on whether they are right or wrong
	public string GenerateFeedback(List<FRule>  right,List<FRule>  wrong,FireWallData inner){
		string feedback = "";

		List<FRule> allInnerRules = new List<FRule> ();
		foreach (var rule in inner.rawinputRules) {
			allInnerRules.Add (rule);
		}
		foreach (var rule in inner.rawoutputRules) {
			allInnerRules.Add (rule);
		}

		print("innerRules"+allInnerRules.Count);

		foreach (var rule in allInnerRules) {
			if (CompareAgainstAList(rule,right)) {
				feedback += "<color=green><size=12>" + rule.FeedbackString() + "</size></color>\n" ;
			} else if (CompareAgainstAList(rule,wrong)) {
				feedback += "<color=red><size=12>" + rule.FeedbackString() + "</size></color>\n";
			}
			else {
				feedback += "<color=yellow><size=12>" + rule.FeedbackString() + "</size></color>\n";

			}
		}
		//allInnerRules.Clear ();
		return feedback;

	}

	public string TutorialCheck(){

		string finalString = "";
	//	string feedback = "";

		FRule correct =new FRule ( "OUTPUT", "177.75.77.12", 22, "ACCEPT" );
		FRule wrong1 =new FRule ( "OUTPUT", "177.75.77.12", 22, "REJECT" );
		FRule wrong2 = new FRule( "OUTPUT", "177.75.77.12", 22, "DROP" );

		List<FRule> rightGreen = new List<FRule> { correct };
		List<FRule> wrongRed = new List<FRule>{ wrong1, wrong2 };

		print (levelComplete);
		//check
		if (checker.LevelCheckOutput (correct, wrong1,innerData) && checker.LevelCheckOutput (correct, wrong2,innerData) ) {
			levelComplete = true;
			print (levelComplete);

			finalString = "<size=48>Good Job</size>\n" + GenerateFeedback(rightGreen,wrongRed,innerData);
			return finalString;
		}
		else {
			finalString = "<size=48>Something is not right,try again</size>\n"+ GenerateFeedback(rightGreen,wrongRed,innerData);
			print (levelComplete);

			return finalString;
		}
			
	}	

	public string Level1Check(){
		string finalString = "";

		FRule correct =new FRule ( "OUTPUT", "177.75.77.12", 80, "ACCEPT" );
		FRule wrong1 =new FRule ( "OUTPUT", "177.75.77.12", 80, "REJECT" );
		FRule wrong2 = new FRule( "OUTPUT", "177.75.77.12", 80, "DROP" );

		FRule correct2 = new FRule ("INPUT", "77.75.77.20", 80, "ACCEPT");
		FRule wrong21 = new FRule ("INPUT", "77.75.77.20", 80, "REJECT");
		FRule wrong22 = new FRule ("INPUT", "77.75.77.20", 80, "DROP");

		List<FRule> rightGreen = new List<FRule> { correct,correct2 };
		List<FRule> wrongRed = new List<FRule>{ wrong1, wrong2,wrong21,wrong22 };	//check

		if (checker.LevelCheckOutput (correct, wrong1,innerData) && checker.LevelCheckOutput (correct, wrong2,innerData)&& checker.LevelCheckInput (correct2, wrong21,innerData)&& checker.LevelCheckInput (correct2, wrong22,innerData) ) {
			levelComplete = true;
			return finalString = "<size=48>Good Job</size>\n" + GenerateFeedback(rightGreen,wrongRed,innerData);

		}
		else {
			return finalString = "<size=48>Something is not right,try again</size>\n"+ GenerateFeedback(rightGreen,wrongRed,innerData);

		}

	}	

	public string Level2Check(){
		string finalString = "";


		FRule correct =new FRule ( "OUTPUT", "177.75.77.12", 23, "ACCEPT" );
		FRule wrong1 =new FRule ( "OUTPUT", "177.75.77.12", 23, "REJECT" );
		FRule wrong2 = new FRule( "OUTPUT", "177.75.77.12", 23, "DROP" );

		FRule correct1 =new FRule ( "OUTPUT", "177.75.77.12", 80, "ACCEPT" );
		FRule wrong11 =new FRule ( "OUTPUT", "177.75.77.12", 80, "REJECT" );
		FRule wrong12 = new FRule( "OUTPUT", "177.75.77.12", 80, "DROP" );

		FRule correct2 = new FRule ("INPUT", "77.75.77.20", 80, "ACCEPT");
		FRule wrong21 = new FRule ("INPUT", "77.75.77.20", 80, "REJECT");
		FRule wrong22 = new FRule ("INPUT", "77.75.77.20", 80, "DROP");

		List<FRule> rightGreen = new List<FRule> { correct,correct1,correct2 };
		List<FRule> wrongRed = new List<FRule>{ wrong1, wrong2,wrong21,wrong22,wrong11,wrong12 };


		//check
		if (checker.LevelCheckOutput (correct, wrong1,innerData) && checker.LevelCheckOutput (correct, wrong2,innerData)&& checker.LevelCheckOutput (correct1, wrong11,innerData)&& checker.LevelCheckOutput (correct1, wrong12,innerData)&& checker.LevelCheckInput (correct2, wrong21,innerData)&& checker.LevelCheckInput (correct2, wrong22,innerData)) {
			levelComplete = true;
			return finalString = "<size=48>Good Job</size>\n" + GenerateFeedback(rightGreen,wrongRed,innerData);

		}
		else {
			return finalString = "<size=48>Something is not right,try again</size>\n"+ GenerateFeedback(rightGreen,wrongRed,innerData);

		}
	}	

	public string Level3Check(){
		string finalString = "";


		FRule correct =new FRule ( "OUTPUT", "177.75.77.12", 80, "ACCEPT" );
		FRule wrong1 =new FRule ( "OUTPUT", "177.75.77.12", 80, "REJECT" );
		FRule wrong2 = new FRule( "OUTPUT", "177.75.77.12", 80, "DROP" );

		FRule correct2 = new FRule ("INPUT", "77.75.77.20", 80, "ACCEPT");
		FRule wrong21 = new FRule ("INPUT", "77.75.77.20", 80, "REJECT");
		FRule wrong22 = new FRule ("INPUT", "77.75.77.20", 80, "DROP");

		FRule correct3 = new FRule ("INPUT", "77.75.77.20", 443, "ACCEPT");
		FRule wrong31 = new FRule ("INPUT", "77.75.77.20", 443, "REJECT");
		FRule wrong32 = new FRule ("INPUT", "77.75.77.20", 443, "DROP");

		FRule correct4 =new FRule ( "OUTPUT", "177.75.77.13", 443, "ACCEPT" );
		FRule wrong41 =new FRule ( "OUTPUT", "177.75.77.13", 443, "REJECT" );
		FRule wrong42 = new FRule( "OUTPUT", "177.75.77.13", 443, "DROP" );

		List<FRule> rightGreen = new List<FRule> { correct,correct3,correct2,correct4 };
		List<FRule> wrongRed = new List<FRule>{ wrong1, wrong2,wrong21,wrong22,wrong31,wrong32,wrong41,wrong42 };

		if (checker.LevelCheckOutput (correct, wrong1,innerData) &&checker.LevelCheckOutput (correct, wrong2,innerData) && checker.LevelCheckInput (correct2, wrong21,innerData)&& checker.LevelCheckInput (correct2, wrong22,innerData)&& checker.LevelCheckInput (correct3, wrong31,innerData)&& checker.LevelCheckInput (correct3, wrong32,innerData)&& checker.LevelCheckOutput (correct4, wrong41,innerData)&& checker.LevelCheckOutput (correct4, wrong42,innerData)) {
			levelComplete = true;
			return finalString = "<size=48>Good Job</size>\n" + GenerateFeedback(rightGreen,wrongRed,innerData);

		}
		
		else {
			return finalString = "<size=48>Something is not right,try again</size>\n"+ GenerateFeedback(rightGreen,wrongRed,innerData);
		}

	}	
	public string Level4Check(){
		string finalString = "";

		//inner
		FRule correct1 =new FRule ( "INPUT", "177.75.78.10", 587, "ACCEPT" );
		FRule wrong11 =new FRule ( "INPUT", "177.75.78.10", 587, "REJECT" );
		FRule wrong12 = new FRule ( "INPUT", "177.75.78.10", 587, "DROP" );

		FRule correct2 =new FRule ( "OUTPUT", "177.75.77.13", 587, "ACCEPT" );
		FRule wrong21 =new FRule ( "OUTPUT", "177.75.77.13", 587, "REJECT" );
		FRule wrong22 = new FRule( "OUTPUT", "177.75.77.13", 587, "DROP" );

		FRule correct3 =new FRule ( "OUTPUT", "177.75.77.12", 587, "ACCEPT" );
		FRule wrong31 =new FRule ( "OUTPUT", "177.75.77.12", 587, "REJECT" );
		FRule wrong32 = new FRule( "OUTPUT", "177.75.77.12", 587, "DROP" );
		//outer
		FRule correct4 = new FRule ("INPUT", "77.75.77.20", 25, "ACCEPT");
		FRule wrong41 = new FRule ("INPUT", "77.75.77.20", 25, "REJECT");
		FRule wrong42 = new FRule ("INPUT", "77.75.77.20", 25, "DROP");

		FRule correct5 = new FRule ( "OUTPUT", "177.75.78.10", 25, "ACCEPT" );
		FRule wrong51 = new FRule ( "OUTPUT", "177.75.78.10", 25, "REJECT" );
		FRule wrong52 = new FRule ( "OUTPUT", "177.75.78.10", 25, "DROP" );


		//inner
		List<FRule> rightGreen = new List<FRule> { correct1,correct3,correct2};
		List<FRule> wrongRed = new List<FRule>{ wrong11, wrong12,wrong21,wrong22,wrong31,wrong32 };
		//outer
		List<FRule> rightGreenOut = new List<FRule> { correct4 };
		List<FRule> wrongRedOut = new List<FRule>{ wrong41,wrong42 };

		if (checker.LevelCheckInput (correct1, wrong11,innerData)&& checker.LevelCheckInput (correct1, wrong12,innerData) && checker.LevelCheckOutput (correct2, wrong21,innerData)&& checker.LevelCheckOutput (correct2, wrong22,innerData)&& checker.LevelCheckOutput (correct3, wrong31,innerData)&& checker.LevelCheckOutput (correct3, wrong32,innerData) && checker.LevelCheckInput(correct4, wrong41,outerData) && checker.LevelCheckInput (correct4, wrong42,outerData)&& checker.LevelCheckInput (correct5, wrong51,outerData)&& checker.LevelCheckInput (correct5, wrong52,outerData)) {
			levelComplete = true;
			return finalString = "<size=48>Good Job</size>\n" + GenerateFeedback(rightGreen,wrongRed,rightGreenOut,wrongRedOut,innerData,outerData);

		}

		else {
			return finalString = "<size=48>Something is not right,try again</size>\n"+ GenerateFeedback(rightGreen,wrongRed,rightGreenOut,wrongRedOut,innerData,outerData);

		}
			
	}	
	public string Level6Check(){
		string finalString = "";


		FRule correct =new FRule ( "INPUT", "200.30.175.162", 2001, "DROP" );
		FRule wrong1 =new FRule ( "INPUT", "200.30.175.162", 2001, "ACCEPT" );
		FRule wrong2 = new FRule( "INPUT", "200.30.175.162", 2001, "REJECT" );
		//check
		List<FRule> rightGreen = new List<FRule> { correct};
		List<FRule> wrongRed = new List<FRule>{ wrong1, wrong2 };
		if (checker.LevelCheckInput (correct, wrong1,innerData) && checker.LevelCheckInput (correct, wrong2,innerData) ) {
			levelComplete = true;

			return finalString = "<size=48>Good Job</size>\n" + GenerateFeedback(rightGreen,wrongRed,innerData);

		}
		else {
			return finalString = "<size=48>Something is not right,try again</size>\n"+ GenerateFeedback(rightGreen,wrongRed,innerData);

		}

	}	

	public string Level5Check(){
		string finalString = "";

		//inner
		FRule correct1 =new FRule ( "OUTPUT", "177.75.78.10", 1433, "ACCEPT" );
		FRule wrong11 =new FRule ( "OUTPUT", "177.75.78.10", 1433, "REJECT" );
		FRule wrong12 = new FRule ( "OUTPUT", "177.75.78.10", 1433, "DROP" );


		FRule correct3 =new FRule ( "INPUT", "177.75.77.12", 1433, "ACCEPT" );
		FRule wrong31 =new FRule ( "INPUT", "177.75.77.12", 1433, "REJECT" );
		FRule wrong32 = new FRule( "INPUT", "177.75.77.12", 1433, "DROP" );

		FRule correct5 = new FRule ("INPUT", "77.75.77.20", 1433, "DROP");
		FRule wrong51 = new FRule ("INPUT", "77.75.77.20", 1433, "ACCEPT");
		FRule wrong52 = new FRule ("INPUT", "77.75.77.20", 1433, "REJECT");
		//outer
		FRule correct2 =new FRule ( "OUTPUT", "177.75.77.12", 1433, "DROP" );
		FRule wrong21 =new FRule ( "OUTPUT", "177.75.77.12", 1433, "REJECT" );
		FRule wrong22 = new FRule( "OUTPUT", "177.75.77.12", 1433, "ACCEPT" );

		//inner
		List<FRule> rightGreen = new List<FRule> { correct1,correct3,correct5};
		List<FRule> wrongRed = new List<FRule>{ wrong11, wrong12,wrong51,wrong52,wrong31,wrong32 };
		//outer
		List<FRule> rightGreenOut = new List<FRule> { correct2 };
		List<FRule> wrongRedOut = new List<FRule>{ wrong21,wrong22 };


		if (checker.LevelCheckOutput (correct1, wrong11,innerData)&& checker.LevelCheckOutput (correct1, wrong12,innerData) && checker.LevelCheckInput (correct3, wrong31,innerData)&& checker.LevelCheckInput (correct3, wrong32,innerData) && checker.LevelCheckInput (correct5, wrong51,innerData) && checker.LevelCheckInput (correct5, wrong52,innerData)&& checker.LevelCheckOutput (correct2, wrong21,outerData)&& checker.LevelCheckOutput (correct2, wrong22,outerData)) {
			levelComplete = true;
			return finalString = "<size=48>Good Job</size>\n" + GenerateFeedback(rightGreen,wrongRed,rightGreenOut,wrongRedOut,innerData,outerData);

		}

		else {
			return finalString = "<size=48>Something is not right,try again</size>\n"+ GenerateFeedback(rightGreen,wrongRed,rightGreenOut,wrongRedOut,innerData,outerData);

		}
			
	}

	public string Level7Check(){
		string finalString = "";


		FRule correct =new FRule ( "INPUT", "77.75.77.20", 80, "DROP" );
		FRule wrong1 =new FRule ( "INPUT", "77.75.77.20", 80, "ACCEPT" );
		FRule wrong2 = new FRule( "INPUT", "77.75.77.20", 80, "REJECT" );

		FRule correct2 =new FRule ( "OUTPUT", "177.75.77.12", 1433, "ACCEPT" );
		FRule wrong21 =new FRule ( "OUTPUT", "177.75.77.12", 1433, "ACCEPT" );
		FRule wrong22 = new FRule( "OUTPUT", "177.75.77.12", 1443, "DROP" );

		FRule correct3 =new FRule ( "INPUT", "200.30.175.162", 1433, "ACCEPT" );
		FRule wrong31 =new FRule ( "INPUT", "200.30.175.162", 1433, "REJECT" );
		FRule wrong32 = new FRule( "INPUT", "200.30.175.162", 1433, "DROP" );
		//check
		//inner
		List<FRule> rightGreen = new List<FRule> { correct,correct3,correct2};
		List<FRule> wrongRed = new List<FRule>{ wrong1, wrong2,wrong21,wrong22,wrong31,wrong32 };

		if (checker.LevelCheckInput (correct, wrong1,innerData) && checker.LevelCheckInput (correct, wrong2,innerData) && checker.LevelCheckOutput (correct2, wrong21,innerData)&& checker.LevelCheckOutput (correct2, wrong22,innerData)&& checker.LevelCheckInput (correct3, wrong31,innerData)&& checker.LevelCheckInput (correct3, wrong32,innerData)) {
			levelComplete = true;
			return finalString = "<size=48>Good Job</size>\n" + GenerateFeedback(rightGreen,wrongRed,innerData);

		}
		else {
			return finalString = "<size=48>Something is not right,try again</size>\n"+ GenerateFeedback(rightGreen,wrongRed,innerData);

		}

	}	

	public string Level8Check(){
		string finalString = "";


			//inner
			FRule correct1 =new FRule ( "OUTPUT", "177.75.77.12", 1433, "ACCEPT" );
			FRule wrong11 =new FRule ( "OUTPUT", "177.75.77.12", 1433, "REJECT" );
			FRule wrong12 = new FRule ( "OUTPUT", "177.75.77.12", 1433, "DROP" );

			FRule correct2 =new FRule ( "INPUT", "177.78.78.7", 1433, "DROP" );
			FRule wrong21 =new FRule ( "INPUT", "177.78.78.7", 1433, "ACCEPT" );
			FRule wrong22 = new FRule( "INPUT", "177.78.78.7", 1443, "REJECT" );

			FRule correct3 =new FRule ( "INPUT", "177.78.78.6", 1433, "ACCEPT" );
			FRule wrong31 =new FRule ( "INPUT", "177.78.78.6", 1433, "REJECT" );
			FRule wrong32 = new FRule( "INPUT", "177.78.78.6", 1433, "DROP" );


			//outer
			FRule correct4 = new FRule ("INPUT", "200.30.175.162", 1433, "DROP");
			FRule wrong41 = new FRule ("INPUT", "200.30.175.162", 1433, "ACCEPT");
			FRule wrong42 = new FRule ("INPUT", "200.30.175.162", 1433, "DROP");

			FRule correct6 = new FRule ("INPUT", "155.55.80.77", 1433, "DROP");
			FRule wrong61 = new FRule ("INPUT", "155.55.80.77", 1433, "ACCEPT");
			FRule wrong62 = new FRule ("INPUT", "155.55.80.77", 1433, "REJECT");

			//inner
			List<FRule> rightGreen = new List<FRule> { correct1,correct3,correct2};
			List<FRule> wrongRed = new List<FRule>{ wrong11, wrong12,wrong21,wrong22,wrong31,wrong32 };
			//outer
			List<FRule> rightGreenOut = new List<FRule> { correct4,correct6 };
			List<FRule> wrongRedOut = new List<FRule>{ wrong41,wrong42,wrong62,wrong62 };


			if (checker.LevelCheckOutput (correct1, wrong11,innerData)&& checker.LevelCheckOutput (correct1, wrong12,innerData) && checker.LevelCheckInput (correct2, wrong21,innerData)&& checker.LevelCheckInput (correct2, wrong22,innerData)&& checker.LevelCheckInput (correct3, wrong31,innerData)&& checker.LevelCheckInput (correct3, wrong32,innerData) && checker.LevelCheckInput(correct4, wrong41,outerData) && checker.LevelCheckInput (correct4, wrong42,outerData)&& checker.LevelCheckInput (correct6, wrong61,outerData) && checker.LevelCheckInput (correct6, wrong62,outerData)) {
			levelComplete = true;	
			return finalString = "<size=48>Good Job</size>\n" + GenerateFeedback(rightGreen,wrongRed,rightGreenOut,wrongRedOut,innerData,outerData);

		}

		else {
			return finalString = "<size=48>Something is not right,try again</size>\n"+ GenerateFeedback(rightGreen,wrongRed,rightGreenOut,wrongRedOut,innerData,outerData);

		}

	}

	public string TestCheck(){
		
		FRule correct =new FRule ( "OUTPUT", "177.75.77.12", 22, "ACCEPT" );
		FRule wrong1 =new FRule ( "OUTPUT", "177.75.77.12", 22, "REJECT" );
		FRule wrong2 = new FRule( "OUTPUT", "177.75.77.12", 22, "DROP" );
		//check
		if (checker.LevelCheckOutput (correct, wrong1,innerData) && checker.LevelCheckOutput (correct, wrong2,innerData)) {
			return "Good Job";
		}
		else {
			return "Something is not right,try again";
		}
			
	}	
		
	public void SetFinalScreenTest(){
		finalScreen.SetActive (true);
		finalScreen.GetComponentInChildren<Text> ().text = TestCheck ();
		}

	public void SetFinalScreenL(){
		finalScreen.SetActive (true);


		print ("out1# " +innerData.outputRules.ToArray ().Length);
		finalScreen.GetComponentInChildren<Text> ().text = Level1Check ();

		print ("out2# " +innerData.outputRules.ToArray ().Length);


	}
	public void SetFinalScreenTutorial(){
		finalScreen.transform.SetAsLastSibling ();

		finalScreen.SetActive (true);
		finalScreen.GetComponentInChildren<Text> ().text = TutorialCheck ();
	}
	public void SetFinalScreen(){
		//start the final screen
		finalScreen.transform.SetAsLastSibling ();
		finalScreen.SetActive (true);
		finalScreen.GetComponentInChildren<Text> ().text = "";

		int level = levelNumber;
		string text;
		//set the text based on level
		switch (level) {
		case 1: { 
				text = Level1Check ();
				break;
			}
		case 2: { 
				text = Level2Check ();
				break;
			}
		case 3: { 
				text = Level3Check ();
				break;
			}
		case 4: { 
				text = Level4Check ();
				break;
			}
		case 5: { 
				text = Level5Check ();
				break;
			}
		case 6: { 
				text = Level6Check ();
				break;
			}
		case 7: { 
				text = Level7Check ();
				break;
			}
		case 8: { 
				text = Level8Check ();
				break;
			}

		default:
			{
				text = "Something went very wrong,sorry";
			}
			break;
		}
		//display the text
		finalScreen.GetComponentInChildren<Text> ().text = text;
	
	}
	public void NextLevel(){
		innerData.ClearAll ();
		outerData.ClearAll ();
		//get the next level name
		string levelname = "Level" + ((levelNumber + 1).ToString());
		if (levelNumber +1 < levelControl.maxLevel && levelComplete) {
			SceneManager.LoadScene (levelname);
			//levelNumber++;
		}
	}
		public void CloseFinalScreen(){
		finalScreen.SetActive (false);
	}
		
}
