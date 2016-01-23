using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
     
     private int x = Screen.width;
     private int y = Screen.height;
  
public int sound;
	void Start () {
	  sound = PlayerPrefs.GetInt("sound");
	  PlayerPrefs.SetInt("character",1);
	}
	
	void OnGUI(){
		if(GUI.Button (new Rect (x/16,y/4,x/4,y/6),"Free Play")) {
			PlayerPrefs.SetInt("gametype",1);
			Application.LoadLevel("Game");
		}
		if(GUI.Button (new Rect (2*x/16+x/4,y/4,x/4,y/6),"Classic Arcade")) {
			PlayerPrefs.SetInt("gametype",2);
			Application.LoadLevel("Game");
		}
		if(GUI.Button (new Rect (3*x/16+2*x/4,y/4,x/4,y/6),"Advanced Arcade")) {
			PlayerPrefs.SetInt("gametype",3);
			Application.LoadLevel("Game");
		}

		if(GUI.Button (new Rect (x/2-x/8,y/2+y/10-y/12,x/4,y/6),"Choose Character")) {
			Application.LoadLevel("Characters");
		}
		if(GUI.Button (new Rect (x-x/10-x/8,y-y/10-y/8,x/8,y/8),"Sound")) {
			if(sound == 1) sound = 0;  else if(sound == 0) sound = 1;
			PlayerPrefs.SetInt("sound",sound);
		}
	}

}
