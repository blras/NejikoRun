using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour {
    public GameObject missle;
    public GameObject target;
    public GameObject Range;
    public float AttackDelay = 100.0f;
    public float atdelay = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (target != null)
        {
            if (atdelay <= 0)
            {
                ShotMissle();
                atdelay = AttackDelay;
            }
            else
            {
                atdelay--;
            }
        }
    }
    void ShotMissle() {
        missle.gameObject.GetComponent<MissleScript>().target = target;
        Instantiate(missle, transform.position, transform.rotation);
    }
   public void getTarget() {
        target = Range.gameObject.GetComponent<RangeScript>().target;
        transform.LookAt(target.transform.position);
    }
}
