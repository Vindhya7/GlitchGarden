using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerprefManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY="master_volume";
	const string DIFFICULTY_KEY="difficulty";
	const string LEVEL_KEY="level_unlocked_";

	public static void Setmastervolume(float volume){

		if (volume >= 0f && volume <= 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError ("Volume out of range");
		}
	}

	public static float Getmastervolume(){


			return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);

	}

	public static void Setlevelunlocked(int level){
		if (level <= Application.levelCount - 1) {
			PlayerPrefs.SetInt (LEVEL_KEY+level.ToString(),1);
		}
	}

	public static bool islevelunlocked(int level){
		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
		bool islevelunlock=(levelValue==1);
		if (level <= Application.levelCount - 1) {
			return islevelunlock;
		}
		return false;
	}

	public static void Setdifficulty(float diff){

		if (diff >= 1f && diff <= 3f) {
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, diff);
		} else {
			Debug.LogError ("");
		}
	}

	public static float Getdifficulty(){


		return PlayerPrefs.GetFloat (DIFFICULTY_KEY);

	}
}
