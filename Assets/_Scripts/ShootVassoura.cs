using UnityEngine;
using System.Collections;

public class ShootVassoura : MonoBehaviour
{
	public Transform targetPos; 
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
			m_poop.GetComponent<PoopMoviment>().rotPoop = (targetPos.position - transform.position).normalized;
			poopTime = 10;
		}
		else
		{
			poopTime -= Time.deltaTime * 10f;
		}
	}
}
