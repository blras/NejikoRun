using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeScript : MonoBehaviour {
    public GameObject Unit;
    public GameObject target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider collision)
    {
        if (collision.tag.Equals("enemy")) {
            if (target == null)
            {
                target = collision.gameObject;
            }
            Unit.gameObject.GetComponent<TowerScript>().getTarget();
        }
    }
}
