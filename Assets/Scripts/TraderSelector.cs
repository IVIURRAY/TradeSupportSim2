using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraderSelector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            // In order for Camera.anything to work we need to tag the
            // camera in the editor as main camera.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider!=null)
                {
                    print(hit.collider.name);
					Transform trader = hit.collider.GetComponentInParent<TraderController>().activeTrader;
					if (trader.name == hit.collider.name)
					{
						// If player selects to active trader then we should put them back to normal.
						trader.GetComponent<Renderer>().material.color = Color.grey;
						hit.collider.GetComponentInParent<TraderController>().activeTrader = null;
						trader.GetComponent<BoxCollider>().material = null;
					}
                }
            }
        }
	}
}
