using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
		string dataAsJson = File.ReadAllText("parsed_dic.json");
    // Pass the json to JsonUtility, and tell it to create a GameData object from it




		// RecItem i1 = new RecItem("Pancakes", "egg", 2, "breakfast", 0.7);
		// RecItem i2 = new RecItem("Waffles", "dough", 2, "breakfast", 0.3);
		// RecItem i3 = new RecItem("Scrambled Eggs", "cookie", 2, "breakfast", 0.05);

		// itemsL.Add(i1);
		// itemsL.Add(i2);
		// itemsL.Add(i3);

		var chosen = "";


		JSHolder js = new JSHolder();


		JSHolder apiData = JsonUtility.FromJson<JSHolder>(A);
		Debug.Log(apiData);

		// List<JSHolder> foodieGoods = JsonUtility.FromJson<JSHolder>(A);
		// List<List<RecItem>> toAddTo = new List<List<RecItem>>();
		// foreach(string s in KeepProb.categories){ //s is the main key
		// 	List<RecItem> he = new List<RecItem>();
		//
		// 	for(int help; help < foodieGoods[s].Length; help++){
		// 		Debug.Log(foodieGoods[s][help]);
		// 		RecItem toPush = JsonUtility.FromJson<RecItem>(foodieGoods[s][help]);
		// 		he.Add(toPush);
		//
		// 	}
		// 	toAddTo.Add(he);
		// }
		//
		// int Normind = Random.Range(0, itemsL.Count);
		//
		// RecItem[] items = itemsL.ToArray();
		// chosen = items[Normind].name;
		// if (KeepProb.foodnames.Contains(chosen) == false){
		// 	KeepProb.foods.Add(items[Normind]);
		// 	KeepProb.foodnames.Add(chosen);
		// }

		GameObject.Find("GachaResult").GetComponent<Text>().text = "You've been Gacha'd: " + A;
		// Debug.Log("You've been Gacha'd: " + Random.value);
	}
}
