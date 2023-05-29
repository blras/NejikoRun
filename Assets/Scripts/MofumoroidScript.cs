using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MofumoroidScript : MonoBehaviour {
    public float speed = 1.0f;
    // Use this for initialization
    private void Awake()
    {

    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider col)
    {

       if (col.tag.Equals("PathStart"))
        {
            gameObject.transform.position = col.transform.position;
            gameObject.transform.rotation = col.transform.rotation;
        }
    }
}
