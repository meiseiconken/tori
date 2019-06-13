using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、消す
public class OnMouseDown_Hide : MonoBehaviour {

	void OnMouseDown() { // タッチしたら
		this.gameObject.SetActive(false); // 消す
	}
}
