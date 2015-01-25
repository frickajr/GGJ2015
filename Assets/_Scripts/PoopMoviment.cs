using UnityEngine;
using System.Collections;

public class PoopMoviment : MonoBehaviour
{
	public Vector3 rotPoop, rotAxis;
	public float speed = 10, angle = 0, angInc = 0;

	// Use this for initialization
	void Start()
	{
		angInc = Random.Range(50.0f, 70.0f);
		rotAxis = new Vector3(1, (float)Random.Range(0, 2), (float)Random.Range(0, 2));

		Debug.Log(rotAxis);
	}

	// Update is called once per frame
	void Update()
	{
		if (transform.position.y <= -10)
			DestroyObject(gameObject);
		transform.position += (rotPoop * speed) * Time.deltaTime;
		transform.Rotate(rotAxis, angle + angInc * Time.deltaTime);
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "player")
			DestroyObject(gameObject);
	}
}
