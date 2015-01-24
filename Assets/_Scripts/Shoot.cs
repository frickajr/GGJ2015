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
			if(Input.anyKey)
			{
				Instantiate(m_bullet, this.transform.position, 
											GetComponentInParent<Transform>().transform.rotation);
				m_bullet.GetComponent<BulletMove>().owner = this.gameObject;
				shootTime = 5;
			}
		}
		else
		{
			shootTime -= (Time.deltaTime * 5f);
		}
	}
}
