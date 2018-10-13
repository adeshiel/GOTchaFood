using System.Collections;
using System;
using System.Collections.Generic;

public static class KeepProb {

	private static float prob;
	public static List<float> probList = new List<float>();

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

	public static string prsl {
		get {
			string[] allProbs = Array.ConvertAll(probList.ToArray(), el => el.ToString());
			return string.Join(", ", allProbs);
		}
	}
}
