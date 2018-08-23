using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePoint : MonoBehaviour
{
	GameObject GamePointText;

	public int Point = 0;        //ポイントの定義と初期化

	//ポイントの加算関数
	public int PointAdd(int a)
	{
		Point += a;
		Debug.Log( Point );
		this.GamePointText.GetComponent<Text>().text = "POINT:" + Point ;
		return Point;
	}

	// Use this for initialization
	void Start()
	{
		//シーン中のGamePointオブジェクトを取得
		this.GamePointText = GameObject.Find("GamePointText");
		//GamePointオブジェクトにポイント0を表示
		this.GamePointText.GetComponent<Text>().text = "POINT:" + Point ;
		Debug.Log( Point );

	}

	// Update is called once per frame
	void Update()
	{
	}
}
	