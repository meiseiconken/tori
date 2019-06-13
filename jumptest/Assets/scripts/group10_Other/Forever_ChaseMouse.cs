using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、マウスを追いかける
public class Forever_ChaseMouse : MonoBehaviour {

	void Start () {
		// 見た目は手前に
		this.GetComponent<SpriteRenderer>().sortingOrder = 100;
	}

	void Update () {
		Vector3 position = Input.mousePosition;
		position.z = 10f; // 他のものへのタッチに影響しないように奥へ
		gameObject.transform.position = Camera.main.ScreenToWorldPoint(position);
	}
}