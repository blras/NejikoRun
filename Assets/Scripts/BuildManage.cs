using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildManage : MonoBehaviour {
    public int Money=45;
    public GameObject Robo;
    public GameObject Tofu;
    public GameObject Mofu;
    public GameObject BuildTower;
    public Text UIMoney;
    public int price =0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        UIMoney.text = "Money: " + Money;
	}
    public void SetTowerRobo()
    {
        BuildTower = Robo;
        price = 10;
    }
    public void SetTowerTofu()
    {
        BuildTower = Tofu;
        price = 50;
    }
    public void SetTowerMofu()
    {
        BuildTower = Mofu;
        price = 200;
    }
}
