using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuttobiScript : MonoBehaviour {

    Rigidbody _rigitbody;
    public float speed = 50f;

	// Use this for initialization
	void Start () {
        _rigitbody =  GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
    void Update () {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        _rigitbody.velocity = transform.up * speed; //up Vector3(0, 1, 0) 
	}


}
