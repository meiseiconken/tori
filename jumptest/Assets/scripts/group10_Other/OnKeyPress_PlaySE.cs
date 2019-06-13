using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押すと、SEが鳴る
public class OnKeyPress_PlaySE : MonoBehaviour {
	public AudioClip se;
    public string inkey = "a";
	bool pushFlag = false;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(inkey)) { // もし、キーが押されたら
			if (pushFlag == false) {
				pushFlag = true;
				gameObject.GetComponent<AudioSource>().PlayOneShot(se);
			}
		} else {
			pushFlag = false;
		}

	}
}
