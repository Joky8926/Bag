using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagPanel : MonoBehaviour {
	public UIGrid _uiGrid;
	private List<GameObject> lstPiece;
	private const int MAX_COUNT = 30;
	private const string PRE_PATH = "Prefab/Piece";

	void Awake() {
		lstPiece = new List<GameObject>();
		InitGrid();
		this.gameObject.SetActive(false);
		MainUIPanel.BagBtnClickEvent += ShowPanel;
	}

	private void ShowPanel() {
		this.gameObject.SetActive(true);
	}

	public void OnClickCloseBtn() {
		this.gameObject.SetActive(false);
	}

	private void InitGrid() {
		for (int  i = 0; i < MAX_COUNT; i++) {
			GameObject goPiece = CreatePiece();
			goPiece.transform.parent = _uiGrid.transform;
			goPiece.transform.localScale = Vector3.one;
			lstPiece.Add(goPiece);
		}
	}

	private GameObject CreatePiece() {
		GameObject pre = Resources.Load<GameObject>(PRE_PATH);
		GameObject goPiece = Instantiate(pre);
		return goPiece;
	}
}
