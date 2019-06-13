using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押すと、スプライトが移動する（水平に）
public class OnKeyPress_MoveSpriteH : MonoBehaviour {

    public float speed = 0.7f; // スピード：Inspectorで指定

    private float vx = 0f;
    private float vy = 0f;

    void Update() { // ずっと行う
        vx = 0f;
        vy = 0f;
        if (Input.GetKey("right")) { // もし、右キーが押されたら
            vx = speed; // 右に進む移動量を入れる
        }
        if (Input.GetKey("left")) { // もし、左キーが押されたら
            vx = -speed; // 左に進む移動量を入れる
        }
    }
    void FixedUpdate() { // ずっと行う（一定時間ごとに）
        this.transform.Translate(vx / 50f, vy / 50f, 0);
    }
}
