using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチすると、アニメーションを切り換える
public class OnMouseDown_ChangeAnime : MonoBehaviour {

	public string normalAnime = "";	// 通常アニメ：Inspectorで指定
	public string nextAnime = "";	// 次のアニメ：Inspectorで指定

	bool touchFlag = false;

	void Start() { // 最初は何もしない
	}

	void OnMouseDown() { // タッチしたら
		touchFlag = !touchFlag;
		Animator animator = this.GetComponent<Animator>();
		if (touchFlag == true) { // 次のアニメに切り換える
			animator.Play(nextAnime);
		} else { // もう一度タッチしたら元のアニメに切り換える
			animator.Play(normalAnime);
		}
	}
}
