using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionAI : MonoBehaviour {
    public int HP = 5;
    public float speed=3.0f;
    public GameObject BuildManage;
    public GameObject WaveManage;
    private int reward;
    // Use this for initialization
    private void Awake()
    {
        
    }
    void Start () {
        HP = WaveManage.GetComponent<WaveManage>().Level+4;
        reward = WaveManage.GetComponent<WaveManage>().Level;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag.Equals("Bullet"))
        {
            HP--;
            Destroy(col.gameObject);
            if (this.HP == 0)
            {
                dieAni();
                WaveManage.GetComponent<WaveManage>().MinionsCount++;
                WaveManage.GetComponent<WaveManage>().MinionsNum--;
                BuildManage.GetComponent<BuildManage>().Money += reward;

            }
        }
        else if (col.tag.Equals("Shock")) {
            HP--;
            if (this.HP == 0)
            {
                dieAni();
                WaveManage.GetComponent<WaveManage>().MinionsCount++;
                WaveManage.GetComponent<WaveManage>().MinionsNum--;
                BuildManage.GetComponent<BuildManage>().Money += reward;

            }
        }
        else if (col.tag.Equals("Mofumoroid"))
        {
            HP--;
            if (this.HP == 0)
            {
                dieAni();
                WaveManage.GetComponent<WaveManage>().MinionsCount++;
                WaveManage.GetComponent<WaveManage>().MinionsNum--;
                BuildManage.GetComponent<BuildManage>().Money += reward;

            }
        }
        else if (col.tag.Equals("PathStart"))
        {
            gameObject.transform.position = col.transform.position;
            gameObject.transform.rotation = col.transform.rotation;
        }
        else if (col.tag.Equals("Goal"))
        {
            Destroy(gameObject);
        }
    }
    void dieAni() {
        gameObject.GetComponent<Animator>().SetTrigger("damage");
    }
    void die() {
        Destroy(gameObject);
    }
}
