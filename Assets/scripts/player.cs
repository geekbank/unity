﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
	}
    public float m_speed = 1;
	// Update is called once per frame
	void Update () {
        //纵向移动距离
        float movev = 0;
        //水平移动距离
        float moveh = 0;
        //按上键
        if( Input.GetKey(KeyCode.UpArrow))
        {
            movev -= m_speed * Time.deltaTime;
        }
        //按下键
        if(Input.GetKey(KeyCode.DownArrow))
        {
            movev += m_speed * Time.deltaTime;
        }
        //按左键
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            moveh += m_speed * Time.deltaTime;
        }
        //按右键
        if(Input.GetKey(KeyCode.RightArrow))
        {
            moveh -= m_speed * Time.deltaTime;
        }
        //移动
        this.transform.Translate( new Vector3(moveh, 0, movev));

	}
}
