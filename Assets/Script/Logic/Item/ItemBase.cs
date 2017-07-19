using System;

public enum EItemType {
	eIT_None,
	eIT_Item,
	eIT_Equip
}

public abstract class ItemBase {
	protected int uItemId;
	protected string sConfId;
	protected EItemType eItemType;
	protected string sItemName;

	public ItemBase(int itemId, string confId) {
		uItemId = itemId;
		sConfId = confId;
	}

	public int f_uItemId {
		get {
			return uItemId;
		}
	}

	public EItemType f_eItemType {
		get {
			return eItemType;
		}
	}

	public string f_sItemName {
		get {
			return sItemName;
		}
	}
}
