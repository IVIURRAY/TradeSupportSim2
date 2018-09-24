using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraderController : MonoBehaviour {

    ArrayList allTraders = new ArrayList();

	// Use this for initialization
	void Start () {
        Transform[] traders = GetComponentsInChildren<Transform>();
        foreach(Transform trader in traders)
        {
            if (trader.tag == "Trader")
            {
                //print(trader.name);
                allTraders.Add(trader);
            }    
        }
        int randomInt = Random.Range(0, 4);
        print(randomInt);
        allTraders[randomInt].GetComponent<Renderer>().material.color = Color.black;

    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
