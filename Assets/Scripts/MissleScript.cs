using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleScript : MonoBehaviour {
    public float damage = 20.0f;
    public float speed = 1500.0f;
    public float lifetime = 500.0f;
    public GameObject target;
    Vector3 offset;
    // Use this for initialization
    void Start () {
        if (target != null)
            offset = transform.position - target.transform.position;
        //transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
	
	// Update is called once per frame
	void Update () {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
            transform.LookAt(target.transform.position);
        }
        if (lifetime == 0)
        {
            Destroy(gameObject);
        }
        else {
            lifetime--; }
    }
}
