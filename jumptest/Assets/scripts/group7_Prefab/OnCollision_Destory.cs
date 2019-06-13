using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突すると、自分自身と相手を削除する
public class OnCollision_Destory : MonoBehaviour {
	
	public string targetObjectName; // 目標オブジェクト名：Inspectorで指定

	void OnCollisionEnter2D(Collision2D collision)  { // 衝突したとき
		// 相手と自分を削除する
		if (collision.gameObject.name == targetObjectName) {
			Destroy(collision.gameObject);
			Destroy(this.gameObject);
		}
	}
}
