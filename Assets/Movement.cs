using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour 
{
	public Rigidbody rb;
	public Transform camera;
	public Vector3 offset;

	void Start () 
	{
		
	}

	void FixedUpdate () 
	{
		rb.AddForce (0, -5, 15);

		camera.position = transform.position + offset;
	}
}
