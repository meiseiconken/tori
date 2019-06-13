using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突すると、表示する（複数対応）
public class OnMultiCollision_Show : MonoBehaviour {

	public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
	public string showObjectName;  // 表示オブジェクト名：Inspectorで指定

	GameObject showObject;
	float orgY = 0;
	float ofsetY = 10000; // この値をY方向に足すことで消す

	void Start() { // 最初に行う
		// 消す前に表示オブジェクトを覚えておいて
		showObject = GameObject.Find(showObjectName);

		// 消す【showObject.SetActive(false); の代わり】
		orgY = showObject.transform.position.y;
		if (orgY > ofsetY) {
			orgY -= ofsetY;
		}
		Vector3 pos = showObject.transform.position;
		pos.y = orgY + ofsetY;
		showObject.transform.position = pos;
	}

	void OnCollisionEnter2D(Collision2D collision) { // 衝突したとき
		// もし、衝突したものの名前が目標オブジェクトだったら
		if (collision.gameObject.name == targetObjectName) {
			// 表示する【showObject.SetActive(true); の代わり】
			Vector3 pos = showObject.transform.position;
			pos.y = orgY;
			showObject.transform.position = pos;
		}
	}
}
