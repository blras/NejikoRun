using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShockScript : MonoBehaviour {
    public float liftTime = 50.0f;
    public GameObject target;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (liftTime == 0)
        {
            Destroy(gameObject);
        }
        else { liftTime--; }
	}
}
