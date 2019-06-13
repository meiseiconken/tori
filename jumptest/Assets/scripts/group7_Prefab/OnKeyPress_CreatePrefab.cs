using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押すと、近くにプレハブを作る
public class OnKeyPress_CreatePrefab : MonoBehaviour {

	public GameObject newPrefab; // 作るプレハブ：Inspectorで指定
	public string inkey = "space";
	public float offsetX = 1;
	public float offsetY = 1;

	bool pushFlag = false;

	void Update () { // ずっと行う
		if(Input.GetKey(inkey)) { // もし、キーが押されたら
			if (pushFlag == false) {
				pushFlag = true;
				Vector3 area = this.GetComponent<SpriteRenderer>().bounds.size;
				Vector3 newPos = this.transform.position;

				newPos.x += offsetX;
				newPos.y += offsetY;
				newPos.z = -5; // 手前に表示
				// プレハブを作る
				GameObject newGameObject = Instantiate(newPrefab) as GameObject;
				newGameObject.transform.position = newPos;
			}
		} else {
			pushFlag = false;
		}
	}

}
