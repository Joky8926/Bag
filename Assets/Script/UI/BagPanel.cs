using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagPanel : MonoBehaviour {
	public UIGrid _uiGrid;
	private List<UIPiece> lstPiece;
	private const int MAX_COUNT = 30;
	private const string PRE_PATH = "Prefab/Piece";

	void Awake() {
		lstPiece = new List<UIPiece>();
		InitGrid();
		InitBagData();
		this.gameObject.SetActive(false);
		MainUIPanel.BagBtnClickEvent += ShowPanel;
	}

	private void ShowPanel() {
		this.gameObject.SetActive(true);
	}

	public void OnClickCloseBtn() {
		this.gameObject.SetActive(false);
	}

	private void InitBagData() {
		List<ItemBase> lstItem = BagMgr.instance.GetAllItem();
		if (lstItem.Count > lstPiece.Count) {
			Debug.LogError("背包中的物品数超过格子数量！！！");
		}
		for (int i = 0; i < lstItem.Count && i < lstPiece.Count; i++) {
			lstPiece[i].Init(lstItem[i]);
		}
	}

	private void InitGrid() {
		for (int i = 0; i < MAX_COUNT; i++) {
			GameObject goPiece = CreatePiece();
			goPiece.transform.parent = _uiGrid.transform;
			goPiece.transform.localScale = Vector3.one;
			UIPiece uiPiece = goPiece.GetComponent<UIPiece>();
			lstPiece.Add(uiPiece);
		}
	}

	private GameObject CreatePiece() {
		GameObject pre = Resources.Load<GameObject>(PRE_PATH);
		GameObject goPiece = Instantiate(pre);
		return goPiece;
	}
}
