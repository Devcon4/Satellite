using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    private float gameSpeed;
    private float radius;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        gameSpeed = Master.master.Scene1.GameSpeed;
        radius = Master.master.Scene1.Radius;
	    var multiplier = (Mathf.Pow(1/radius, 2) * Mathf.PI)/gameSpeed;
        transform.Rotate(Vector3.forward * multiplier);
	}
}
