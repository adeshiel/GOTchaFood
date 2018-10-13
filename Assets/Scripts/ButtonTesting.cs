﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using static RecItem;

public class ButtonTesting : MonoBehaviour {

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

	}

	public void GACHA () {
		float val = Random.value;


		RecItem i1 = new RecItem("Pancakes", "egg", 2, "breakfast", 0.7);
		RecItem i2 = new RecItem("Waffles", "dough", 2, "breakfast", 0.3);
		RecItem i3 = new RecItem("Scrambled Eggs", "cookie", 2, "breakfast", 0.05);

		List<RecItem> itemsL = new List<RecItem>();
		itemsL.Add(i1);
		itemsL.Add(i2);
		itemsL.Add(i3);
		var chosen = "";
		// RecItem chosen;

		RecItem[] items = itemsL.ToArray();
		// RecItem items = []
		for(int i = 0; i < items.Length; i++){
			chosen = items[i].name;
			if (items[i].pullprob < val){
				if (KeepProb.foodnames.Contains(items[i].name) == false){
					KeepProb.foods.Add(items[i]);
					KeepProb.foodnames.Add(items[i].name);
					break;
				}
			}
		}

		// KeepProb.probList.Add(val);

		GameObject.Find("GachaResult").GetComponent<Text>().text = "You've been Gacha'd: " + chosen;
		// Debug.Log("You've been Gacha'd: " + Random.value);
	}
}
