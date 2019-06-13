using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour {

	void Start () {
		float x = transform.position.x;
		if (x > 0) {
			Debug.Log("右");
		} else {
			Debug.Log("左");
		}
	}

	void Update () {
	}
}
