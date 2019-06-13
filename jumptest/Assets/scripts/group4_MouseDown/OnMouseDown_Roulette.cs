using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、ルーレットのように回転する
public class OnMouseDown_Roulette : MonoBehaviour {

	public float maxSpeed = 50; // 最大スピード：Inspectorで指定

	float rotateAngle = 0;

	void OnMouseDown() { // タッチしたら
		rotateAngle = maxSpeed; // 最大スピードを出す
	}
	void FixedUpdate() { // ずっと行う（一定時間ごとに）
		rotateAngle = rotateAngle * (float)0.98; // 回転量を少しずつ減らして
		this.transform.Rotate(0,0,rotateAngle); // 回転する
	}
}
