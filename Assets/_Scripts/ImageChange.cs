using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ImageChange : MonoBehaviour
{
	public GameObject telaAtual;
	public List<GameObject> scenes;
	// Use this for initialization
	void Start()
	{
		telaAtual = scenes[0];
	}

	// Update is called once per frame
	void Update()
	{

	}
}
