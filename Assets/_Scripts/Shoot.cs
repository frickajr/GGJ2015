using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
	public GameObject m_bullet;
	public float shootTime = 5;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update() 
	{
		if(shootTime <= 0)
		{
			if(Input.GetKey(KeyCode.Space))
			{
				Instantiate(m_bullet, this.transform.position, 
											GetComponentInParent<Transform>().transform.rotation);
				shootTime = 10;
			}
		}
		else
		{
			shootTime -= (Time.deltaTime * 10f);
		}
	}
}
