using UnityEngine;
using System.Collections;

public class ColorShift : MonoBehaviour
{
	private float mf_decrefactor = 0.7f;

	/*void Start()
	{
		light.color = new Color(Random.Range(0.0f, 1.1f),
														Random.Range(0.0f, 1.1f),
														Random.Range(0.0f, 1.1f));
	}*/

	// Update is called once per frame
	void Update()
	{
		GetComponent<WSP_LaserBeamWS>().LaserBeamColor = 
					ChangeBG(GetComponent<WSP_LaserBeamWS>().LaserBeamColor);
	}

	public Color ChangeBG(Color cor)
	{
		//Dimiui vermelho
		if ((cor.r <= 1.0f && cor.r > 0.1f)
				&& cor.g >= 1.0f && cor.b >= 1.0f)
		{
			cor.r -= mf_decrefactor * Time.deltaTime;
			if (cor.r < 0.15f)
				cor.r = 0.0f;
		}
		//Diminui verde
		else if (cor.r <= 0.1f && cor.b >= 1.0f
						 && (cor.g <= 1.0f && cor.g > 0.1f))
		{
			cor.g -= mf_decrefactor * Time.deltaTime;
			if (cor.g < 0.15f)
				cor.g = 0.0f;
		}
		//Aumenta vermelho
		else if ((cor.r >= 0.0f && cor.r < 1.0f)
						&& cor.g <= 0.0f && cor.b >= 1.0f)
		{
			cor.r += mf_decrefactor * Time.deltaTime;
			if (cor.r > 0.9f)
				cor.r = 1.0f;
		}
		//Diminui Azul
		else if (cor.r >= 1.0f && cor.g <= 0.1f
						 && (cor.b <= 1.0f && cor.b >= 0.1f))
		{
			cor.b -= mf_decrefactor * Time.deltaTime;
			if (cor.b < 0.15f)
				cor.b = 0.0f;
		}
		//Aumenta verde
		else if (cor.r >= 1.0f && cor.b <= 0.1f
						&& (cor.g >= 0.0f && cor.g < 1.0f))
		{
			cor.g += mf_decrefactor * Time.deltaTime;
			if (cor.g > 0.9f)
				cor.g = 1.0f;
		}
		//Diminui vermelho
		else if ((cor.r <= 1.0f && cor.r > 0.1f)
						&& cor.g >= 1.0f && cor.b <= 0.1f)
		{
			cor.r -= mf_decrefactor * Time.deltaTime;
			if (cor.r < 0.15f)
				cor.r = 0.0f;
		}
		//Aumenta vermelho/azul
		else if ((cor.r >= 0.0f && cor.r < 1.0f)
						&& cor.g >= 1.0f
						&& (cor.b >= 0.0f && cor.b < 1.0f))
		{
			cor = new Color(cor.r + mf_decrefactor * Time.deltaTime,
											cor.g,
											cor.b + mf_decrefactor * Time.deltaTime);
			if (cor.r > 0.9f)
				cor.r = 1.0f;
			if (cor.b > 0.9f)
				cor.b = 1.0f;
		}
		//Debug.Log(cor);
		return cor;
	}
}