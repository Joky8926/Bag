using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log(Application.dataPath);
		Debug.Log(Resources.LoadAll("Data").Length);
		Debug.Log(Resources.Load("Data/string_conf"));
		TextAsset txt = Resources.Load("Data/string_conf") as TextAsset;
		Debug.Log(txt.text);
		BagMgr.instance.PrintItems();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
