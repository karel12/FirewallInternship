using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FRule  {

	public string chain;
	public string ip;
	public int port;
	public string policy;
	public int number;

	public string FeedbackString(){
		if (port == 2001) {
			return chain+" "+ policy + " "  + "2001:65535" + " " + ip;	
		}
		return  chain+" "+ policy + " "  + port.ToString() + " " + ip;
	}

	public string ToString(){
		if (port == 2001) {
			return " \t\t\t\t\t\t\t\t" +number + " \t\t\t\t" + policy + " \t\t\t\t\t\t\t"  + "2001:65535" + " \t\t\t\t\t\t" + ip;	
		}
		return " \t\t\t\t\t\t\t\t" +number + " \t\t\t\t" + policy + "  \t\t\t\t\t\t\t\t"  + port.ToString () + " \t\t\t\t\t\t" + ip;
	}
	public FRule (string _chain,string _ip,int _port,string _policy){
		chain = _chain;
		ip = _ip;
		port = _port;
		policy = _policy;
		number = 0;
	}
}
