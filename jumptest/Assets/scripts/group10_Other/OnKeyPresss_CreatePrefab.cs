using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キー（aなど）を押したら、そのオブジェクトの近くにプレハブを作る
public class OnKeyPresss_CreatePrefab : MonoBehaviour {

	public GameObject newPrefab; // 作るプレハブ：Inspectorで指定
	public string inkey = "a";
	public float offsetX = 1;
	public float offsetY = 1;

	bool pushFlag = false;

	void Update () { // ずっと行う
		if(Input.GetKey(inkey)) { // もし、キーが押されたら
			if (pushFlag == false) {
                pushFlag = true;
                Vector2 area = this.GetComponent<SpriteRenderer>().bounds.size;
				Vector2 newPos = this.transform.position;

                newPos.x += offsetX;
                newPos.y += offsetY;
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
