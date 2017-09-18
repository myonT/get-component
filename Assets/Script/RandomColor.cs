using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour {

    Renderer _renderer;

	// Use this for initialization
	void Awake () {
        _renderer = this.GetComponent<Renderer>();//自分（当たられる方）の色コンポーネトげっと
		
	}
	
	// Update is called once per frame
	void Start () {
        _renderer.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);//ランダムな色にかえる

	}

    private void Update()
    {
        
    }

    public Color GetBodyColor(){
        return _renderer.material.color;//colorcubebehaviourで動く　最初に作ったランダムなカラーが入れられて、相手に渡される
    }

    public void ChangeColor(){
        _renderer.material.color = new Color(Random.value, Random.value, Random.value, 1.0f);//また自分の色をランダムにかえる
    }
}
