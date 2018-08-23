using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour 
{
	private GamePoint gamePoint;

	// Use this for initialization
	void Start()
	{
		gamePoint = GameObject.Find("Ball").GetComponent<GamePoint>();
		//シーン中のGamePointオブジェクトを取得
	}
	void Update()
	{
	}

	//衝突判定
	//衝突物の特定
	//衝突物に応じたポイントの指定
	//指定したポイントをカウンター関数に引数として与える。
	void OnCollisionEnter(Collision collision)
	{
		Debug.Log(collision.collider.name);

		//ボールがLargeCloudに衝突した場合
		if (collision.gameObject.CompareTag("LargeCloudTag"))
		{
			//ポイント10を引数としてカウンター関数に渡す
			//GamePointクラスの変数を宣言してインスタンスを代入
			gamePoint.PointAdd(10);
			//ポイント加算用の関数を呼び出す

			//ボールがSmallCloudに衝突した場合
		}
		else if (collision.gameObject.CompareTag("SmallCloudTag"))
		{
			//ポイント20を引数としてカウンター関数に渡す
			//GamePointクラスの変数を宣言してインスタンスを代入
			gamePoint.PointAdd(20);
			//ポイント加算用の関数を呼び出す
			Debug.Log(collision.collider.name);

			//ボールがLargeStarに衝突した場合
		}
		else if (collision.gameObject.CompareTag("LargeStarTag"))
		{
			//ポイント30を引数としてカウンター関数に渡す
			//GamePointクラスの変数を宣言してインスタンスを代入
			gamePoint.PointAdd(30);
			//ポイント加算用の関数を呼び出す
			Debug.Log(collision.collider.name);
		
			//ボールがSmallStarに衝突した場合
		}
		else if (collision.gameObject.CompareTag("SmallStarTag"))
		{
			//ポイント40を引数としてカウンター関数に渡す
			gamePoint.PointAdd(40);
			//ポイント加算用の関数を呼び出す
			Debug.Log(collision.collider.name);
		}
		//GamePointTextオブジェクトに合計ポイントを表示

	}

}	