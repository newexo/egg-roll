using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float acceleration;
	public GUIText counttext;
	public GUIText victorytext;
	public GameObject pickups;
	private int count;

	void updatetext()
	{
		int maxcount = pickups.GetComponent<Pickups>().count;
		counttext.text = "Count: " + count.ToString();
		if (count < maxcount) 
		{
			victorytext.text = "You have not won yet.";
		}
		else
		{
			victorytext.text = "You win!";
		}
	}

	void Start ()
	{
		count = 0;
		updatetext ();
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
			count++;
			updatetext();
		}
	}
}
