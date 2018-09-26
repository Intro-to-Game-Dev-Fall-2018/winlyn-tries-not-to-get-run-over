using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chicken1 : MonoBehaviour
{

	public float speed;
	public Text countText1;
	
	private Rigidbody2D rb2d;
	private int count1;	
	
	// Use this for initialization
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		count1 = 0;
		SetCountText1();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		float moveVertical1 = Input.GetAxis("Vertical1");
		Vector2 movement = new Vector2(0.0f, moveVertical1);
		rb2d.AddForce(movement * speed);
	}

	void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "Score")
		{
			count1 = count1 + 1;
			SetCountText1();
			transform.position = new Vector2(-4.15f, -7.15f);
		}
		if (collisionInfo.gameObject.tag == "Car")
		{
			transform.position = new Vector2(-4.15f, -7.15f);
		}
	}

	void SetCountText1()
	{
		countText1.text = "" + count1.ToString();
	}
}

