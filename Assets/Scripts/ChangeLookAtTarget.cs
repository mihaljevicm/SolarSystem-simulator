using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour
{
    //private float x;
   // private float y;
    //private float z;
    //public int Distance;
   // public static int Pos;
    

    
	// Use this for initialization
	void Start () {
       // Pos = Distance*2;
	}
	
	// Update is called once per frame
	void Update ()
    {
       // x = transform.position.x;
       // y = transform.position.y;
        //z = transform.localScale.x + transform.position.z*Distance;
        //LookAtTarget.Offset = new Vector3(x,y,z);
    }

	void OnMouseDown()
	{
		LookAtTarget.Target = transform;
        //LookAtTarget.Offset = new Vector3(x, y, -z * Time.deltaTime);

    }
}
