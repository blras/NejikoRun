using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManage : MonoBehaviour {
    public int Level;
    public GameObject Minion;
    public GameObject mofumoroid;
    public GameObject BuildManage;
    public GameObject StartBlock;
    public int MinionsCount;
    public int MinionsNum;
    private Transform StartPoint;
    private Coroutine currentCoroutine=null;
    // Use this for initialization
    private void Awake()
    {
        Level = 1;
        Minion.GetComponent<MinionAI>().BuildManage = BuildManage;
        Minion.GetComponent<MinionAI>().WaveManage = gameObject;
        StartPoint = StartBlock.transform;
    }
    void Start () {
        currentCoroutine=StartCoroutine(MinionIns(1));
	}


    // Update is called once per frame
    void Update () {
	}
    IEnumerator MinionIns(float delayTime) {
        if (MinionsNum < 100)
        {
            Level = 1 + MinionsCount / 20;
            Instantiate(Minion, StartPoint.position, StartPoint.rotation);
            MinionsNum++;
            yield return new WaitForSeconds(delayTime);
            currentCoroutine = StartCoroutine(MinionIns(1));
        }
        else StopCoroutine(currentCoroutine);
    }
    public void Mofumoroid()
    {
        if (BuildManage.GetComponent<BuildManage>().Money >= 200)
        {
            Instantiate(mofumoroid, StartPoint.position, StartPoint.rotation);
            BuildManage.GetComponent<BuildManage>().Money -= 200;
        }
    }
    }
