using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {



	public float acceleration;
	private int count;

	void Start ()
	{
		count = 0;
	}

	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		var movement = new Vector3 (moveHorizontal, 0, moveVertical);

		GetComponent<Rigidbody>().AddForce(movement * acceleration * Time.deltaTime);
		
	}

	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive(false);
			count = count + 1;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}

