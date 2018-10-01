using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour {

	// Use this for initialization

	public float speed;
	public float y;

	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate(speed * Time.deltaTime, 0, 0);
	}
	void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "Left")
		{
			transform.position = new Vector2(10.5f, y);
		}
		if (collisionInfo.gameObject.tag == "Right")
		{
			transform.position = new Vector2(-10.5f, y);
		}
	}
}

