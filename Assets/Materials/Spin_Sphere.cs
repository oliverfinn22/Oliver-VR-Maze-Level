using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin_Sphere : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
	transform.Rotate(new Vector3(0,20,0) * Time.deltaTime);
    }
}
