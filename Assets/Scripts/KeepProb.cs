using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

public static class KeepProb {

	private static float prob;
	public static List<float> probList = new List<float>();
	public static List<RecItem> foods = new List<RecItem>();
	public static List<string> foodnames = new List<string>();


	public static float Probability {
		get {
			return prob;
		}
		set {
			prob = value;
		}
	}

	public static List<float> ProbabilityList {
		get {
			return probList;
		}
	}

		public static List<RecItem> FoodList {
			get {
				return foods;
			}

	}

	public static List<string> FoodNameList {
		get {
			return foodnames;
		}

}

	public static List<string> foodstringList {
		get{
			string[] allProbs = Array.ConvertAll(foods.ToArray(), el => el.ToString());
			return allProbs.OfType<string>().ToList();
		}
	}


	public static List<string> stringList {
		get{
			string[] allProbs = Array.ConvertAll(probList.ToArray(), el => el.ToString());
			return allProbs.OfType<string>().ToList();
		}
	}

	public static string prsl {
		get {
			string[] allProbs = Array.ConvertAll(probList.ToArray(), el => el.ToString());
			return string.Join(", ", allProbs);
		}
	}
}
