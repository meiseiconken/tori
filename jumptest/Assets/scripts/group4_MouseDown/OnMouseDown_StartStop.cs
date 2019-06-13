using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、アニメーションを再生＆停止
public class OnMouseDown_StartStop : MonoBehaviour {

	public float speed = 0;

	void Start () { // 最初に行う。停止
		this.GetComponent<Animator>().speed = speed;
	}
	void OnMouseDown() { // タッチしたら
		speed = 1 - speed; // 再生と停止を切り換える
		this.GetComponent<Animator>().speed = speed;
	}
}
