using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 下キーを押したら、そこにプレハブを作る
public class OnDownKeyPress_CreatePrefab : MonoBehaviour {

	public GameObject newPrefab; // 作るプレハブ：Inspectorで指定

	bool pushFlag = false;

	void Update() {
		if (Input.GetKey("down")) { // もし、下キーが押されたら
			if (pushFlag == false) {
				pushFlag = true;
				Vector2 area = this.GetComponent<SpriteRenderer>().bounds.size;
				Vector2 newPos = this.transform.position;

                newPos.y -= (area.y/2);
				// プレハブを作る
				GameObject newGameObject = Instantiate(newPrefab) as GameObject;
				newGameObject.transform.position = newPos;
				// 手前に表示する
				newGameObject.GetComponent<SpriteRenderer>().sortingOrder = 100;
			}
		} else {
			pushFlag = false;
		}
	}
}
