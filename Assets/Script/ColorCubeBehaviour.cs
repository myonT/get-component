using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubeBehaviour : MonoBehaviour {

    private RandomColor _randomColor;//すくりぷとを入れるところつくってる？
    Renderer renderc;//

    void Awake(){
        _randomColor = this.GetComponent<RandomColor>();//randomcolorscriptをgetcomponent?
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        renderc = collision.gameObject.GetComponent<Renderer>();//衝突相手の色コンポーネント
        renderc.material.color = _randomColor.GetBodyColor();//衝突相手の色 ＝ randomcolorscriptのGetBodyColor()の中に入っている色にする

		_randomColor.ChangeColor();//randomcolorscriptのchangecolorを動かして当たった後自分の色をかえる
	}
}
