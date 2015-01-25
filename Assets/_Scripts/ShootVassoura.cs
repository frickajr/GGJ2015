using UnityEngine;
using System.Collections;

public class ShootVassoura : MonoBehaviour
{
	public Vector3 targetPos;
	public GameObject m_poop;
	public float poopTime = 10;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if(poopTime <= 0)
		{
			Instantiate(m_poop, transform.position, Quaternion.identity);

		}
	}
}
