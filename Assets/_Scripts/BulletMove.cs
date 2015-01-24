using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.forward * 5f * Time.deltaTime);
	}

	void OnTriggerEnter(Collider col)
	{
		Debug.Log("Colidiu");
	}
}
