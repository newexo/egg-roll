using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour 
{
	public Vector3 eulerangle;

	void Update () 
	{
		transform.Rotate (eulerangle * Time.deltaTime);
	}
}
