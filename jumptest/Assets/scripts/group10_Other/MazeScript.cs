using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeScript : MonoBehaviour {

	public GameObject newPrefab; // 作るプレハブ：Inspectorで指定
	public float bsize = 1.5f;

	// Use this for initialization
	void Start () {
		Camera mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
		Vector3 topLeft = mainCamera.ScreenToWorldPoint(Vector3.zero);
		int[,] blocks = new int[,] {
			{ 1,1,1,1,1,1,1,1,1,1,1 },
			{ 1,0,0,0,0,0,0,0,0,0,0 },
			{ 1,0,1,0,1,0,1,0,1,0,1 },
			{ 1,0,0,0,0,0,0,0,0,0,1 },
			{ 1,0,1,0,1,0,1,0,1,0,1 },
			{ 1,0,0,0,0,0,0,0,0,0,1 },
			{ 1,0,1,0,1,0,1,0,1,0,1 },
			{ 0,0,0,0,0,0,0,0,0,0,1 },
			{ 1,1,1,1,1,1,1,1,1,1,1 } };

		// 枠と柱を作る
		int i, j;
		for (i = 0; i <= 8; i++) {
			for (j = 0; j <= 10; j ++) {
				if (blocks[i,j]==1) {
					GameObject newGameObject = Instantiate(newPrefab) as GameObject;
					newGameObject.transform.localScale = new Vector3(bsize, bsize, 1);
					float w = newGameObject.GetComponent<SpriteRenderer>().bounds.size.x;
					float wx = topLeft.x + w / 2.0f + (j + 1) * w ;
					float wy = topLeft.y + w / 2.0f + (i + 1) * w ;
					newGameObject.transform.position = new Vector2(wx, wy);
					newGameObject.GetComponent<SpriteRenderer>().sortingOrder = 100;

				}
			}
		}

		// 迷路
		for (i = 2; i <= 6; i+=2) {
			for (j = 2; j <= 8; j+=2) {
				GameObject newGameObject = Instantiate(newPrefab) as GameObject;
				newGameObject.transform.localScale = new Vector3(bsize, bsize, 1);
				float w = newGameObject.GetComponent<SpriteRenderer>().bounds.size.x;
				float vx = 0;
				float vy = 0;
				int r = Random.Range(0, 3);
				switch (r) {
					case 0:
						vx = 1;
					break;
					case 1:
						vx = -1;
					break;
					case 2:
						vy = 1;
					break;
					case 3:
						vy = -1;
					break;
				}
				float wx = topLeft.x + w / 2.0f + (j + 1 - vx) * w;
				float wy = topLeft.y + w / 2.0f + (i + 1 - vy) * w;
				newGameObject.transform.position = new Vector2(wx, wy);
				newGameObject.GetComponent<SpriteRenderer>().sortingOrder = 200;
			}
		}
	}
}
