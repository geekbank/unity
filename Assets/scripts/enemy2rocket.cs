using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2rocket : rocket {

	private void OnTriggerEnter(Collider other)
	{
        if (other.tag.CompareTo("Player") != 0)
            return;
        Destroy(this.gameObject);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

