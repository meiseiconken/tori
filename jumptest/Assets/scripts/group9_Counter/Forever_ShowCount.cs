using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ずっと、カウントの値を表示する
public class Forever_ShowCount: MonoBehaviour {

	void Update() { // ずっと
		// カウンターの値を表示する
		GetComponent<Text>().text = GameCounter.value.ToString();
	}
}
