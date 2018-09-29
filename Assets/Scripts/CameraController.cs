using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private float distance = 0.1f;
    private float maxHeight = 4f;

    private Vector3 startPos;
    public GameObject target; // GameObject that we want to look at while moving

	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        MoveCamera(); // When space is pressed we want to move the camera up until a max.

    }

    private void MoveCamera()
    {
        Vector3 movePos = transform.position;
        if (Input.GetKey(KeyCode.Space))
        {
            if (movePos.y + distance > maxHeight)
            {
                movePos = new Vector3(movePos.x, maxHeight, movePos.z);
            }
            else
            {
                movePos = new Vector3(movePos.x, movePos.y + distance, movePos.z);
            }
        }
        else if (movePos.y - distance > 0)
        {
            movePos = new Vector3(movePos.x, movePos.y - distance, movePos.z);
        }
        else
        {
            movePos = startPos;
        }

        transform.LookAt(target.transform);
        transform.position = movePos;
    }
}
