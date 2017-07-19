using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIPanel : MonoBehaviour {
	public static event BtnClickDelegate BagBtnClickEvent;

	public void OnClickBagBtn() {
		if (BagBtnClickEvent != null) {
			BagBtnClickEvent();
		}
	}
}
