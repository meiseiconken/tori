using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突すると、カウントを増やす
public class OnCollision_Count : MonoBehaviour {
	
	public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
	public int addValue = 1;	// 増加量：Inspectorで指定

	void OnCollisionEnter2D(Collision2D collision)  { // 衝突したとき
		// もし、衝突したものの名前が目標オブジェクトだったら
		if (collision.gameObject.name == targetObjectName) {
			// カウンターの値を増やす
			GameCounter.value = GameCounter.value + addValue;
		}
	}
}
