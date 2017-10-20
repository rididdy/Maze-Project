using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public GameObject coin;
	public GameObject CoinPoof;


	float xpos;
	float zpos;

	public void Start()
	{
	}

	public void Update()
	{
		// floating coin animation
		transform.position = new Vector3(transform.position.x, 3 + Mathf.Sin(Time.time * 2), transform.position.z);

	}

	public void OnPointerClick() 
	{

		// Locate the instantiated coin position.
		xpos = transform.position.x;
		zpos = transform.position.z;


		//instantiate the poof prefab 
		Object.Instantiate(CoinPoof, new Vector3(xpos, 0, zpos), Quaternion.Euler(-90, 0, 0));
		
		//destroy the coin
		//DestroyImmediate(coin, true);
		Destroy(coin);
	
	}
}