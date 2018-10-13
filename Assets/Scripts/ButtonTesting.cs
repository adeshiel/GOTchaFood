using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTesting : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void GACHA () {
		float val = Random.value;
		KeepProb.probList.Add(val);
		GameObject.Find("GachaResult").GetComponent<Text>().text = "You've been Gacha'd: " + val;
		// Debug.Log("You've been Gacha'd: " + Random.value);
	}
}
