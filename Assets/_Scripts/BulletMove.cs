using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour 
{
	public GameObject owner;
	public float alphaTime;

	// Use this for initialization
	void Start () 
	{
		alphaTime = 5;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Death();
		transform.Translate(Vector3.forward * 5f * Time.deltaTime);
	}

	void Death()
	{
		if (renderer.material.color.a <= 0.0f)
			DestroyObject(gameObject);

		//Loop do crescimento e da alteração do alfa
		if (alphaTime < 0)
		{
			renderer.material.color = new Color(renderer.material.color.r,
									renderer.material.color.g, renderer.material.color.b,
									renderer.material.color.a - 0.5f * Time.deltaTime);
		}
		else
		{
			alphaTime -= 5f * Time.deltaTime;
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "obj")
		{
			DestroyObject(col.gameObject);
			DestroyObject(this.gameObject);
		}
	}
}
