using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIPanel : MonoBehaviour {
	public static event BtnClickDelegate BagBtnClickEvent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClickBagBtn() {
		Debug.Log("ClickBagBtn");
		if (BagBtnClickEvent != null) {
			BagBtnClickEvent();
		}
	}
}
