using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突すると、ゲームをストップする
public class OnCollision_StopGame : MonoBehaviour {
	
	public string targetObjectName; // 目標オブジェクト名：Inspectorで指定

	void Start () { // 最初に行う
		// 時間を動かす
		Time.timeScale = 1;
	}

	void OnCollisionEnter2D(Collision2D collision)  { // 衝突したとき
		// もし、衝突したものの名前が目標オブジェクトだったら
		if (collision.gameObject.name == targetObjectName) {
			// 時間を止める
			Time.timeScale = 0;
		}
	}
}
