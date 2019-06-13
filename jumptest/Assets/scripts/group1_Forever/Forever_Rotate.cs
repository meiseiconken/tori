using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、回転する
public class Forever_Rotate : MonoBehaviour {

	public float angle = 90; // 角度：Inspectorで指定

	void FixedUpdate() { // ずっと行う（一定時間ごとに）
		this.transform.Rotate(0, 0, angle/50);	// 回転する
	}
}
