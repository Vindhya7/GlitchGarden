using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fadein : MonoBehaviour {

	public float fadeintime;
	private Image fadepanel;
	private Color currcolor=Color.black;
	// Use this for initialization
	void Start () {
		fadepanel = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(Time.timeSinceLevelLoad<fadeintime){

			float alphachange = Time.deltaTime / fadeintime;
			currcolor.a -= alphachange;
			fadepanel.color = currcolor;
		}else{
			gameObject.SetActive (false);
		}
		
	}
}
