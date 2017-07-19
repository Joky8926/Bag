using UnityEngine;
using System.Collections.Generic;

public class BagMgr {
	private static BagMgr _instance;
	private List<ItemBase> lstItem;

	private BagMgr() {
		lstItem = new List<ItemBase>();
		InitItem();
	}

	public static BagMgr instance {
		get {
			if (_instance == null) {
				_instance = new BagMgr();
			}
			return _instance;
		}
	}

	private void InitItem() {
		lstItem.Add(new Equip(1, "equip_1", 2));
		lstItem.Add(new Item(2, "item_2", 3));
	}

	public void PrintItems() {
		for (int i = 0; i < lstItem.Count; i++) {
			if (lstItem[i].f_eItemType == EItemType.eIT_Equip) {
				Debug.Log((lstItem[i] as Equip).f_uAddLevel);
			} else if (lstItem[i].f_eItemType == EItemType.eIT_Item) {
				Debug.Log((lstItem[i] as Item).f_uCount);
			}
		}
	}
}
