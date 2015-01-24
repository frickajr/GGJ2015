using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour 
{
	public GameObject owner;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Death();
		transform.Translate(Vector3.forward * 5f * Time.deltaTime);
	}

	void Death()
	{
		if(owner != null)
			if (Vector3.Distance(owner.transform.position, this.transform.position)
					>= 100)
				DestroyObject(this.gameObject);
	}

	void OnTriggerEnter(Collider col)
	{
		Debug.Log("Colidiu");
	}
}
