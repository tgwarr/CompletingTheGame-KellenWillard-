﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
	private Rigidbody targetRB;

    void Start()
    {
		targetRB = GetComponent<Rigidbody>();
		targetRB.AddForce(Vector3.up*Random.Range(14,19),ForceMode.Impulse);
		targetRB.AddTorque(Random.Range(-5,5),Random.Range(-5,5),Random.Range(-5,5),ForceMode.Impulse);
		transform.position = new Vector3(Random.Range(-5,5),-5,0);

    }
		
    void Update()
    {
        
    }
}
