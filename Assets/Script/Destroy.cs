using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    private Renderer _renderer;

	// Use this for initialization
	void Start () {
		_renderer = gameObject.GetComponent<Renderer>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OK");
        //_renderer.enabled = false; これで見た目消える　enabledつかえる！
        Destroy(gameObject);// thisとgameobjectの違い　
//		Destroy(gameObject)は、コンポーネントを持つgameObjectが削除される。
//      Destroy(this)は、コンポーネントが削除される（this = Destroyを呼び出したコンポーネント）
        //Destroy(collision.gameObject); これだと衝突相手
    }
}
