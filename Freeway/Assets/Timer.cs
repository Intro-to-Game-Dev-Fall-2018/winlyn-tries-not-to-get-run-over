using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{

	public float counter;
	
	// Use this for initialization
	void Start ()
	{
		//GameObject.Find("Chicken1").GetComponent<Chicken1>().count1 += 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		counter += Time.deltaTime;
		if (counter >= 5.0f)
		{
	
		}
	}
}
