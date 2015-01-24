using UnityEngine;
using System.Collections;

public class rotateDolphin : MonoBehaviour {

    public float speed;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x,
                                            transform.eulerAngles.y,
                                            transform.eulerAngles.z + Time.time * speed);
	}
}
