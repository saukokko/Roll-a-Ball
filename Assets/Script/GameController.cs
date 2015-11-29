using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {


	public UnityEngine.UI.Text scoreLablel;
	public GameObject winnerLabelObject;

	// Update is called once per frame
	public void Update () {

		int count = GameObject.FindGameObjectsWithTag ("Item").Length;
		scoreLablel.text = count.ToString ();

		if (count == 0) {
			// クリア時の処理
			winnerLabelObject.SetActive (true);
		}
	
	}
}
