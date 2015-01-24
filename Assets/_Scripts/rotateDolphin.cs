using UnityEngine;
using System.Collections;

public class rotateDolphin : MonoBehaviour {

    public float speed, speedMin, speedMax;
    public Transform rangeInitial, rangeFinal;

	void Start () {
        ValueRandom();
	}
	
	// Update is called once per frame
	void Update () {
        transform.eulerAngles = new Vector3 (transform.eulerAngles.x,
                                             transform.eulerAngles.y,
                                             transform.eulerAngles.z + Time.deltaTime * speed);

        if (transform.eulerAngles.z > 170 && transform.eulerAngles.z < 190)
        {
            ValueRandom();
        }            
	}

    void ValueRandom()
    {
        transform.position = new Vector3(0, 0,
                                               Random.Range(rangeInitial.position.z,
                                                            rangeFinal.position.z));
        speed = Random.Range(speedMin, speedMax);
    }
}
