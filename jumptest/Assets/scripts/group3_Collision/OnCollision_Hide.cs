using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突すると、消す
public class OnCollision_Hide : MonoBehaviour {

	public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
	public string hideObjectName;   // 消すオブジェクト名：Inspectorで指定

	void Start() { // 最初は何もしない
	}

	void OnCollisionEnter2D(Collision2D collision)  { // 衝突したとき
		// もし、衝突したものの名前が目標オブジェクトだったら
		if (collision.gameObject.name == targetObjectName) {
			// 消すオブジェクトを探して
			GameObject hideObject = GameObject.Find(hideObjectName);
			hideObject.SetActive(false); // 消す
		}
	}
}
