using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突すると、そこにプレハブを作る
public class OnCollision_CreatePrefab : MonoBehaviour {

	public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
	public GameObject newPrefab;    // 作るプレハブ：Inspectorで指定

	void OnCollisionEnter2D(Collision2D collision)  { // 衝突したとき
		// もし、衝突したものの名前が目標オブジェクトだったら
		if (collision.gameObject.name == targetObjectName) {
			// 衝突位置にプレハブを作る
			GameObject newGameObject = Instantiate(newPrefab) as GameObject;
			Vector3 pos = collision.contacts[0].point;
			pos.z = -5; // 手前に表示
			newGameObject.transform.position = pos;
		}
	}
}
