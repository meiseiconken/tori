using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、ドラッグ開始する
public class OnMouseDown_DragStart: MonoBehaviour {

	bool dragFlag = false;
	void OnMouseDown() {
		dragFlag = true;
		// 見た目は手前に
        this.GetComponent<SpriteRenderer>().sortingOrder = 100;
	}
	void OnMouseUp() {
		dragFlag = false;
	}
	void Update() { // ずっと行う
		if (dragFlag) {
			Vector3 position = Input.mousePosition;
			position.z = 10f; // 他のものへのタッチに影響しないように奥へ
			gameObject.transform.position = Camera.main.ScreenToWorldPoint(position);
		}
	}
}
