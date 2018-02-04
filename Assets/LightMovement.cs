using UnityEngine;

public class LightMovement : MonoBehaviour 
{
	public Transform cube;
	public Transform light;
	public Vector3 offset;

	void Start () 
	{

	}

	void FixedUpdate () 
	{
		light.position = cube.position + offset;
	}
}
