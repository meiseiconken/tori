using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、カウントを増やす
public class OnMouseDown_Count : MonoBehaviour {

	public int addValue = 1;	// 増加量：Inspectorで指定

	void OnMouseDown() { // タッチしたら
		// カウンターの値を増やす
		GameCounter.value = GameCounter.value + addValue;
	}
}
