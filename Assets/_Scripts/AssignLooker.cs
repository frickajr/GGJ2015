using UnityEngine;
using System.Collections;

public class AssignLooker : MonoBehaviour 
{
	public GameObject looker;

	// Use this for initialization
	void Start ()
	{
		looker = GameObject.Find("Looker");
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<WSP_LaserBeamWS>().CurrentTarget = looker.GetComponent<Transform>().transform;
	
	}
}
