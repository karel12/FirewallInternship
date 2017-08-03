using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(menuName = "NetworkUI/Service")]
public class Service : ScriptableObject {

	public string name;
	//what port it listens to
	public string usingPort;
	//need Input/Output or Both
	public string direction;

	public string GetServiceAsString(){
	
		return (name + "  using port:" + usingPort + "  In direction:" + direction + "\n");

	}
		
}