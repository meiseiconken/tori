using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// カウントが最終値なら、消す
public class OnCountFinished_Hide : MonoBehaviour {

	public int lastCount = 3; // カウンターの最終値：Inspectorで指定
	public string hideObjectName;  // 消すオブジェクト名：Inspectorで指定

	void Start() { // 最初は何もしない
	}

	void FixedUpdate() { // ずっと行う（一定時間ごとに）
		// カウンターが最終値になったら
		if (GameCounter.value == lastCount) {
			// 消すオブジェクトを探して
			GameObject hideObject = GameObject.Find(hideObjectName);
			hideObject.SetActive(false); // 消す
		}
	}
}
