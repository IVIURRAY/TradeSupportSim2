using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trader : MonoBehaviour {

	[SerializeField]
	private Rigidbody rb;
	public bool Active;

	// Maybe each trader could give their own bouncyness
	public float bouncyness;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
