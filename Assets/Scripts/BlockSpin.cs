using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpin : MonoBehaviour {
    public int State=0;
    public Animator anim;
    public GameObject StartPoint;
    // Use this for initialization
    private void Awake()
    {
        anim = transform.GetComponent<Animator>();
    }
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        //회전 조건: 1라인에는 무조건 1개는 0이 있어야 한다.
        //0:0,1,2,3,4;1:
        anim.SetInteger("BlockState", State);
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Block")) {
            anim.SetBool("Collider", true);
        }
    }
}
