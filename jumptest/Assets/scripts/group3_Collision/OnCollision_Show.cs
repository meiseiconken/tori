using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突すると、表示する
public class OnCollision_Show : MonoBehaviour {

	public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
	public string showObjectName;   // 表示オブジェクト名：Inspectorで指定

	GameObject showObject;

	void Start() { // 最初に行う
		// 消す前に表示オブジェクトを覚えておいて
		showObject = GameObject.Find(showObjectName);
		showObject.SetActive(false); // 消す
	}

	void OnCollisionEnter2D(Collision2D collision) { // 衝突したとき
		// もし、衝突したものの名前が目標オブジェクトだったら
		if (collision.gameObject.name == targetObjectName) {
			showObject.SetActive(true); // 消していたものを表示する
		}
	}
}
