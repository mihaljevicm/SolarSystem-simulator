using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundTarget : MonoBehaviour {

    public Vector3 Axsis;
    public float Speed;
    public Transform Target;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.RotateAround(Target.position, Axsis, Speed);
		
	}
}
