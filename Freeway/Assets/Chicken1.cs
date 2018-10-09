using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chicken1 : MonoBehaviour
{

	public float speed;
	public Text countText1;
	
	public int count1;
	
	// Use this for initialization
	void Start()
	{
		count1 = 0;
		SetCountText1();
		
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		float moveVertical1 = Input.GetAxis("Vertical1");
		transform.Translate(0, moveVertical1 * speed * Time.deltaTime, 0);
	}

	void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "Score")
		{
			count1 = count1 + 1;
			SetCountText1();
			transform.position = new Vector2(-4.15f, -5.76f);
		}
		if (collisionInfo.gameObject.tag == "Car")
		{
			transform.position = new Vector2(-4.15f, -5.765f);
			FindObjectOfType<Audio>().Play("chiknscrem");

		}
	}

	void SetCountText1()
	{
		countText1.text = "" + count1.ToString();
	}
}

