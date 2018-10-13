using System.Collections;
using System.Collections.Generic;
// using UnityEngine;

public class RecItem {
	public string name;
	public string group;
	public string ingredients;
	public int cooktime;
	public double pullprob;

	public RecItem (string Name, string Ing, int Time, string Fam, double probab){
		name = Name;
		ingredients = Ing;
		cooktime = Time;
		group = Fam;
		pullprob = probab;

		}

}
