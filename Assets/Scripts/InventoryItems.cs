using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItems : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var current_list = KeepProb.probList.ToArray();
		var current_string = KeepProb.prsl;
		if (current_list.Length != 0 && current_list != null){
			GameObject.Find("ItemsText").GetComponent<Text>().text = "Current probs: " + current_string + "\n" + "There are " + current_list.Length + " item(s).";
		}
		else {
				GameObject.Find("ItemsText").GetComponent<Text>().text = "No Items";
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
