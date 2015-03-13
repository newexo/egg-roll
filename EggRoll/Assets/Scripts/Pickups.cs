﻿using UnityEngine;
using System.Collections;

public class Pickups : MonoBehaviour {
	public int count;
	public float r;
	public Rigidbody prefab;
	private Stack s;

	void Start () {
//		var q = new Vector3(r * Mathf.Cos(1 * Mathf.PI / count), r * Mathf.Sin(1 * Mathf.PI / count), 0.5f);
//		clone = (Rigidbody) Instantiate(prefab, q, prefab.rotation);

		s = new Stack();
		float phi = 2.0f * Mathf.PI / count;
		for (int i = 0; i < count; i++) 
		{
			var q = new Vector3(r * Mathf.Cos(i * phi), 0.5f, r * Mathf.Sin(i * phi));
			Rigidbody clone = (Rigidbody) Instantiate(prefab, q, prefab.rotation);
			s.Push(clone);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
