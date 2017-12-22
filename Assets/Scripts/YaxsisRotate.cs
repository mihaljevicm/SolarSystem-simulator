using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YaxsisRotate : MonoBehaviour {

    public Vector3 Axsis;
    public float Speed;
    public Transform Target;

    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(Axsis, Speed * Time.deltaTime);
    }
}
