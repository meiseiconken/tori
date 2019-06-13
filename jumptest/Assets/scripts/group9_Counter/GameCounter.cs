using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// カウンター本体
public class GameCounter : MonoBehaviour {

	public static int value; // 共有するカウンターの値

	public int startCount = 0; // カウンター初期値：Inspectorで指定

	void Start() { // 最初に行う
		value = startCount;// カウンターをリセット
	}
}
