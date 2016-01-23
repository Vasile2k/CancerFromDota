using UnityEngine;
using System.Collections;

public class Characters : MonoBehaviour {

     private int x = Screen.width;
     private int y = Screen.height;

	
	void OnGUI(){
      if(GUI.Button (new Rect (1.5f*x/16,3*y/4,x/6,y/6),"SELECT")) {
			PlayerPrefs.SetInt("character",1);
			Application.LoadLevel("Main");
		}
		if(GUI.Button (new Rect (2.5f*x/16+x/4,3*y/4,x/6,y/6),"SELECT")) {
			PlayerPrefs.SetInt("character",2);
			Application.LoadLevel("Main");
		}
		if(GUI.Button (new Rect (3.5f*x/16+2*x/4,3*y/4,x/6,y/6),"SELECT")) {
			PlayerPrefs.SetInt("character",3);
			Application.LoadLevel("Main");
		}
	}

}
