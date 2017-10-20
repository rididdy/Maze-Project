using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
//Create a reference to the KeyPoofPrefab and Door
	public GameObject KeyPoof;
	public GameObject key;
	public Door door;



	void Update()
	{
		// floating key animation (vertical)

		transform.position = new Vector3(transform.position.x, 3 + Mathf.Sin(Time.time * 2), transform.position.z);


	}

	public void OnKeyClicked()
	{

		// Instatiate the Poof Prefab where this key is located

		Object.Instantiate(KeyPoof, new Vector3(2.5f, 0, 0), Quaternion.Euler(-90, 0, 0));

		//call the Unlock() method
		door.Unlock();

		// Destroy the keyprefab

		Destroy(key);

	}

}