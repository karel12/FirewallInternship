using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu(menuName = "NetworkUI/LevelControl")]
public class LevelControl : ScriptableObject {
	
	public int maxLevel;

	public FireWallData data1;
	public FireWallData data2;


	public void GoToTutorial(){
		data1.ClearAll ();
		data2.ClearAll ();

		SceneManager.LoadScene ("Tutorial");
	}

	public void GoToLevel1(){
		data1.ClearAll ();
		data2.ClearAll ();
	
		SceneManager.LoadScene ("Level1");
	}

	public void GoToLevel2(){
		data1.ClearAll ();
		data2.ClearAll ();

		SceneManager.LoadScene ("Level2");
	}

	public void GoToLevel3(){
		data1.ClearAll ();
		data2.ClearAll ();

		SceneManager.LoadScene ("Level3");
	}
	public void GoToLevel4(){
		data1.ClearAll ();
		data2.ClearAll ();

		SceneManager.LoadScene ("Level4");
	}
	public void GoToLevel5(){
		data1.ClearAll ();
		data2.ClearAll ();

		SceneManager.LoadScene ("Level5");
	}
	public void GoToLevel6(){
		data1.ClearAll ();
		data2.ClearAll ();

		SceneManager.LoadScene ("Level6");
	}

	public void GoToLevel7(){
		data1.ClearAll ();
		data2.ClearAll ();

		SceneManager.LoadScene ("Level7");
	}

	public void GoToLevel8(){
		data1.ClearAll ();
		data2.ClearAll ();

		SceneManager.LoadScene ("Level8");
	}

	public void GoToTitle(){
	
		SceneManager.LoadScene ("TitleScreen");
		data1.ClearAll ();
		data2.ClearAll ();
	}

	public void GoToLevelSelect(){

		SceneManager.LoadScene ("LevelSelect");
		data1.ClearAll ();
		data2.ClearAll ();
	}
		
	public void Quit(){
		Application.Quit ();
	
	}
}
