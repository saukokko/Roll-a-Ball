using UnityEngine;
using System.Collections;

public class DangerWall : MonoBehaviour {

	void OnCollisionEnter ( Collision hit){

		// 接触したオブジェクトのタグが"Player"の場合
		if (hit.gameObject.CompareTag ("Player")) {

			// 現在のシーンを再読み込みする
			Application.LoadLevel (Application.loadedLevel);
		}

	}
}
