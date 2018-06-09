using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superenemy : enemy {
    protected override void UpdateMove(){
        
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update () {
        //前进
        m_trasform.Translate(new Vector3(0, 0, m_speed * Time.deltaTime));
    }
       
    
        
    
}
