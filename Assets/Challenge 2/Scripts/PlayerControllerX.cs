using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
	public GameObject dogPrefab;

	public float timer = 0.0f;

	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime;

		// On spacebar press, send dog
		if (timer > 2 && (Input.GetKeyDown(KeyCode.Space) || (Application.isEditor && Input.GetKeyDown(KeyCode.O))))
		{
			Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
			timer = 0.0f;
		}
	}
}
