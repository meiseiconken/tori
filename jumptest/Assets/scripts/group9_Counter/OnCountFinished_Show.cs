using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// カウントが最終値なら、表示する
public class OnCountFinished_Show : MonoBehaviour {
	
	public int lastCount = 3; // カウンターの最終値：Inspectorで指定
	public string showObjectName;  // 表示オブジェクト名：Inspectorで指定

	GameObject showObject;

	void Start () { // 最初に行う
		// 消す前に表示オブジェクトを覚えておいて
		showObject = GameObject.Find(showObjectName);
		showObject.SetActive(false); // 消す
	}

	void FixedUpdate() { // ずっと行う（一定時間ごとに）
		// カウンターが最終値になったら
		if (GameCounter.value == lastCount) {
			showObject.SetActive(true); // 消していたものを表示する
		}
	}
}
