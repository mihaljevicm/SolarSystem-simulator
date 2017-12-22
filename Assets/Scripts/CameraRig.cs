using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRig : MonoBehaviour {

    private Transform Target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       

    }
    void LateUpdate()
    {
        transform.position = LookAtTarget.Target.transform.position + LookAtTarget.Offset + LookAtTarget.Target.localScale;
    }
}
