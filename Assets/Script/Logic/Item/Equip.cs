using System;

public class Equip : ItemBase {
	private int uAddLevel;

	public Equip(int itemId, string confId, int addLevel) : base(itemId, confId) {
		uAddLevel = addLevel;
		eItemType = EItemType.eIT_Equip;
	}

	public int f_uAddLevel {
		get {
			return uAddLevel;
		}
	}
}
