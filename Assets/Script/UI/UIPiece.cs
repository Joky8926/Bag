using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPiece : MonoBehaviour {
	public UISprite iconSprite;
	public UILabel nameLabel;
	public UILabel countLabel;
	public UILabel otherLabel;
	private ItemBase itemVO;

	void Awake() {
		iconSprite.gameObject.SetActive(false);
	}

	public void Init(ItemBase item) {
		itemVO = item;
		if (itemVO == null) {
			iconSprite.gameObject.SetActive(false);
		} else {
			iconSprite.gameObject.SetActive(true);
			nameLabel.text = itemVO.f_sItemName;
			if (itemVO.f_eItemType == EItemType.eIT_Equip) {
				countLabel.text = "";
				otherLabel.text = (itemVO as Equip).f_uAddLevel.ToString();
			} else if (itemVO.f_eItemType == EItemType.eIT_Item) {
				countLabel.text = (itemVO as Item).f_uCount.ToString();
				otherLabel.text = "";
			}
		}
	}
}
