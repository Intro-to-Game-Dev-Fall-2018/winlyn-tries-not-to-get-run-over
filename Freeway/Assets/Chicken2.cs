using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chicken2 : MonoBehaviour
{

	public float speed;
	public Text countText2;

	private Rigidbody2D rb2d;
	private int count2;

	// Use this for initialization
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		count2 = 0;
		SetCountText2();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		float moveVertical2 = Input.GetAxis("Vertical2");
		Vector2 movement = new Vector2(0.0f, moveVertical2);
		rb2d.AddForce (movement * speed);
	}
	
	void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "Score")
		{
			count2 = count2 + 1;
			SetCountText2();
			transform.position = new Vector2(3.88f, -7.15f);
		}
		if (collisionInfo.gameObject.tag == "Car")
		{
		transform.position = new Vector2(4.15f, -7.15f);
		}
	}

	void SetCountText2()
	{
		countText2.text = "" + count2.ToString();
	}
}
