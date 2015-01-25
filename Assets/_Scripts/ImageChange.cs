using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ImageChange : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
		StartCoroutine("Load");
	}

	// Update is called once per frame
	void Update()
	{

	}

	IEnumerator Load()
	{
		yield return new WaitForSeconds(8);
		Application.LoadLevel("rift_move");
	}

}