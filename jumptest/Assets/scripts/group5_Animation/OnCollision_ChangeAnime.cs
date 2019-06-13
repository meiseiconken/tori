using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突すると、アニメーションを切り換える
public class OnCollision_ChangeAnime : MonoBehaviour {
	
	public string targetObjectName; // 目標オブジェクト名：Inspectorで指定
	public string normalAnime = ""; // 通常アニメ：Inspectorで指定
	public string nextAnime = "";   // 次のアニメ：Inspectorで指定
	public int changeSec = 1;	// 戻る秒数：Inspectorで指定

	void OnCollisionEnter2D(Collision2D collision)  { // 衝突したとき
		// もし、衝突したものの名前が目標オブジェクトだったら
		if (collision.gameObject.name == targetObjectName) {
			Animator animator = this.GetComponent<Animator>();
			animator.Play(nextAnime); // 次のアニメに切り換える
			Invoke("setNormalPose", changeSec);
		}
	}
	void setNormalPose() {
			// 指定秒経ったら元のアニメに切り換える
			Animator animator = this.GetComponent<Animator>();
			animator.Play(normalAnime);
	}
}
