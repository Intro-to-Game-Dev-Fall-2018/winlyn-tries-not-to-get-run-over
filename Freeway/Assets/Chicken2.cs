using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chicken2 : MonoBehaviour
{

	public float speed;
	public Text countText2;

	public int count2;

	// Use this for initialization
	void Start()
	{
		count2 = 0;
		SetCountText2();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		float moveVertical2 = Input.GetAxis("Vertical2");
		transform.Translate(0, moveVertical2 * speed * Time.deltaTime, 0);
	}
	
	void OnCollisionEnter2D(Collision2D collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "Score")
		{
			count2 = count2 + 1;
			SetCountText2();
			transform.position = new Vector2(3.88f, -5.76f);
		}
		if (collisionInfo.gameObject.tag == "Car")
		{
		transform.position = new Vector2(4.15f, -5.76f);
		FindObjectOfType<Audio>().Play("chiknscrem");
		}
	}

	void SetCountText2()
	{
		countText2.text = "" + count2.ToString();
	}
}
