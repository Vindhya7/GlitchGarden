using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OptionController : MonoBehaviour {

	public Slider volumeslider;
	public Slider difficultyslider;
	public LevelManager levelmanager;
	private MusicManager music;

	// Use this for initialization
	void Start () {
		music = GameObject.FindObjectOfType<MusicManager> ();
		volumeslider.value = PlayerprefManager.Getmastervolume ();
		difficultyslider.value = PlayerprefManager.Getdifficulty ();
	}
	
	// Update is called once per frame
	void Update () {
		music.ChangeVolume (volumeslider.value);

	}

	public void saveandexit(){
		PlayerprefManager.Setmastervolume (volumeslider.value);
		PlayerprefManager.Setdifficulty (difficultyslider.value);
		levelmanager.LoadLevel ("Start Menu");
	}

	public void setdefault(){
		volumeslider.value = 0.8f;
		difficultyslider.value = 2f;
	}
}
