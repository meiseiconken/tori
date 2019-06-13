using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、移動する（垂直）
public class Forever_MoveV : MonoBehaviour {

	public float speed = 1; // スピード：Inspectorで指定

	void FixedUpdate() { // ずっと行う（一定時間ごとに）
		this.transform.Translate(0 ,speed / 50, 0); // 垂直移動する
	}
}

