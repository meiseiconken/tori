using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突すると、消す（複数対応）
public class OnMultiCollision_Hide : MonoBehaviour {

	public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
	public string hideObjecttName;  // 消すオブジェクト名：Inspectorで指定

	GameObject hideObject;
	float orgY = 0;
	float ofsetY = 10000; // この値をY方向に足すことで消す

	void Start() { // 最初に行う
		// 消すオブジェクトを探しておく
		hideObject = GameObject.Find(hideObjecttName);
		orgY = hideObject.transform.position.y;
	}

	void OnCollisionEnter2D(Collision2D collision)  { // 衝突したとき
		// もし、衝突したものの名前が目標オブジェクトだったら
		if (collision.gameObject.name == targetObjectName) {
			// 消す【hideObject.SetActive(false); の代わり】
			Vector3 pos = hideObject.transform.position;
			pos.y = orgY + ofsetY;
			hideObject.transform.position = pos;
		}
	}
}
