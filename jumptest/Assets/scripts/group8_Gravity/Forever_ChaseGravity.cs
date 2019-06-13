using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、追いかける（重力対応版）
public class Forever_ChaseGravity : MonoBehaviour {

	public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
	public float speed = 1; // スピード：Inspectorで指定

	GameObject targetObject;
	Rigidbody2D rbody;

	void Start () { // 最初に行う
		// 目標オブジェクトを見つけておく
		targetObject = GameObject.Find(targetObjectName);
		// 衝突時に回転させない
		rbody = GetComponent<Rigidbody2D>();
		rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}

	void FixedUpdate() { // ずっと行う（一定時間ごとに）
		// 目標オブジェクトの方向を調べて
		Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;
		// その方向へ指定した量で進む（重力をかけたまま）
		float vx = dir.x * speed;
		rbody.velocity = new Vector2(vx, rbody.velocity.y);
		// 進む方向で左右の向きを変える
		SpriteRenderer sprite = this.GetComponent<SpriteRenderer>();
		sprite.flipX = (vx < 0); 
	}
}
