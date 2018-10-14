using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItems : MonoBehaviour {
	Dropdown f_Dropdown;

	// Use this for initialization
	void Start () {
		var current_list = KeepProb.foods.ToArray();
		var current_string = KeepProb.prsl;
		var current_prob = KeepProb.Probability;


		if (current_list.Length != 0 && current_list != null){
			GameObject.Find("ItemsText").GetComponent<Text>().text = "# of items: " + current_list.Length + "\n";
			f_Dropdown = GameObject.Find("Dropdown").GetComponent<Dropdown>();
			f_Dropdown.ClearOptions();
			f_Dropdown.AddOptions(KeepProb.foodnames);
		}
		else {
				List<string> def = new List<string>();
				def.Add("None");
				GameObject.Find("ItemsText").GetComponent<Text>().text = "No Items";
				f_Dropdown = GameObject.Find("Dropdown").GetComponent<Dropdown>();
				f_Dropdown.ClearOptions();
				f_Dropdown.AddOptions(def);
		}
	}

	// Update is called once per frame
	void Update () {

		var cur_item = KeepProb.foods.ElementAt(f_Dropdown.value);
		GameObject.Find("Detailed Text").GetComponent<Text>().text = "Main ingredient: " + cur_item.ing;

	}
}
