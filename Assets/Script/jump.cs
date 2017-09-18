using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {
    public float power = 500f;
    private Rigidbody _rigitbody;

	// Use this for initialization
	void Start () {
        _rigitbody = this.GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.UpArrow)){
            this._rigitbody.AddForce(Vector3.up*power);
            
        }
		
	}
}
