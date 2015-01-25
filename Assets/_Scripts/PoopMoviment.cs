using UnityEngine;
using System.Collections;

public class PoopMoviment : MonoBehaviour
{
	public Vector3 rotPoop;
	public float speed = 10;

	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (transform.position.y <= -10)
			DestroyObject(gameObject);
		transform.position += rotPoop * speed;
	}
}
