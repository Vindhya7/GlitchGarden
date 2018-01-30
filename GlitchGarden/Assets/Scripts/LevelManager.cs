using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {


	public float autoloadnextlevel;

	void Start(){

		if(autoloadnextlevel==0){
			Debug.Log ("auto load");
		}else{
		Invoke ("LoadNextLevel",autoloadnextlevel);
		}
	}

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	public void LoadNextLevel(){
		
		Application.LoadLevel (Application.loadedLevel+1);
	}



}
