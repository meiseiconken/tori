using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、そこにプレハブを作る
public class OnMouseDown_CreatePrefab : MonoBehaviour {

	public GameObject newPrefab; // 作るプレハブ：Inspectorで指定

	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			// タッチした位置をカメラの中での位置に変換して
			var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition + Camera.main.transform.forward);
			pos.z = -5; // 手前に表示
			// 新しいプレハブを作ってその位置に移動する
			GameObject newGameObject = Instantiate(newPrefab) as GameObject;
			newGameObject.transform.position = pos;
		}
	}
}
