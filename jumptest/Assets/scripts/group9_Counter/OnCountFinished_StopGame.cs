using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// カウントが最終値なら、ゲームをストップする
public class OnCountFinished_StopGame : MonoBehaviour {

	public int lastCount = 3; // カウンターの最終値：Inspectorで指定
	
	void Start () { // 最初に行う
		Time.timeScale = 1; // 時間を動かす
	}

	void FixedUpdate() { // ずっと行う（一定時間ごとに）
		// カウンターが最終値になったら
		if (GameCounter.value == lastCount) {
			Time.timeScale = 0; // 時間を止める
		}
	}
}
