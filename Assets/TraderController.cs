using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraderController : MonoBehaviour {

    ArrayList allTraders = new ArrayList();
	public Transform activeTrader;
	public PhysicMaterial bounceMaterial;

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
		

    }

    // Update is called once per frame
    void Update()
    {
		if (activeTrader == null)
		{
			// this means that the trader has been deselected so lets select it again
			SetActiveTrader();
			MakeActiveTraderJump();
		}
    }

	private void MakeActiveTraderJump()
	{
		Vector3 jump = new Vector3(0, 10, 0);
		activeTrader.GetComponent<Rigidbody>().AddForce(jump, ForceMode.Impulse);
		activeTrader.GetComponent<BoxCollider>().material = bounceMaterial;
	}

	private void SetActiveTrader() {
		// Randomly change one of the cubes to black
		int randomInt = UnityEngine.Random.Range(0, 4);
		activeTrader = (Transform)allTraders[randomInt];
		activeTrader.GetComponent<Renderer>().material.color = Color.black;

	}
}
