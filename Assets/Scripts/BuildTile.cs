using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTile : MonoBehaviour {
    public int num;
    public bool tower;
    public GameObject BuildManage;
    public GameObject Tower;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseEnter()
    {
       // Debug.Log(num);
    }
    public void TowerIns() {
        if (!tower)
        {
            if (BuildManage.GetComponent<BuildManage>().Money >= BuildManage.GetComponent<BuildManage>().price)
            {
                BuildManage.GetComponent<BuildManage>().Money -= BuildManage.GetComponent<BuildManage>().price;
                Tower=Instantiate(BuildManage.GetComponent<BuildManage>().BuildTower, transform.position, transform.rotation);
                tower = true;
            }
        }
        else if(tower) {
            Destroy(Tower);
            tower = false;
        }
    }
}
