using System;

public class Item : ItemBase {
	private int uCount;

	public Item(int itemId, string confId, int count) : base(itemId, confId) {
		uCount = count;
		eItemType = EItemType.eIT_Item;
	}

	public int f_uCount {
		get {
			return uCount;
		}
	}
}
