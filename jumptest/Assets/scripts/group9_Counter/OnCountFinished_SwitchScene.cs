using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;	// シーン切り替えに必要

// カウントが最終値なら、シーンを切り換える
public class OnCountFinished_SwitchScene : MonoBehaviour {

	public int lastCount = 3; // カウンターの最終値：Inspectorで指定
	public string sceneName = ""; // シーン名：Inspectorで指定

	void FixedUpdate() { // ずっと行う
		// カウンターが最終値になったら
		if (GameCounter.value == lastCount) {
			// シーンを切り換える
			SceneManager.LoadScene (sceneName);
		}
	}
}
