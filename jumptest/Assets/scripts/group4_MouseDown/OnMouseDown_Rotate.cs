using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、回転する
public class OnMouseDown_Rotate : MonoBehaviour {

	public float angle = 360; // 角度：Inspectorで指定

	float rotateAngle = 0;

	void OnMouseDown() { // タッチしたら
		rotateAngle = angle; // 回転量を指定する
	}

	 void OnMouseUp() { // タッチをやめたら
		rotateAngle = 0; // 回転量を0にする
	}

	void FixedUpdate() { // ずっと行う（一定時間ごとに）
		this.transform.Rotate(0,0,rotateAngle/50); // 回転量で回転する
	}
}
