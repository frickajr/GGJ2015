using UnityEngine;
using System.Collections;

public class move : MonoBehaviour
{

	public float speed, limitBack, distance;
	public Vector3 direction;


	void Update()
	{
		if (transform.position.z <= limitBack)
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + distance);
		else
			transform.Translate(Time.deltaTime * speed * direction);
	}
}
