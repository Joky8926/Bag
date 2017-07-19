using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagPanel : MonoBehaviour {

	void Awake() {
		this.gameObject.SetActive(false);
		MainUIPanel.BagBtnClickEvent += ShowPanel;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void ShowPanel() {
		this.gameObject.SetActive(true);
	}

	public void OnClickCloseBtn() {
		this.gameObject.SetActive(false);
	}
}
