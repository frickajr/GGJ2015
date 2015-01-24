using UnityEngine;
using System.Collections;

public class loopTexture : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public float scrollSpeed = 0.5F;
    void Update()
    {
        float offset = Time.time * scrollSpeed;
        renderer.material.SetTextureOffset("_MainTex", new Vector2(0, -offset));
        renderer.material.SetTextureOffset("_BumpMap", new Vector2(0, -offset));

    }
}
