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
public class supperenemy:enemy{
    public Transform m_rocket;  //子弹
    protected float m_fireTimer = 2; //设计计时器
    protected Transform m_player;    //主角
	private void Awake()
	{
        GameObject
        obj = GameObject.FindGameObjectWithTag("player"); //查找主角
        if(obj!=null)
        {
            m_player = obj.transform;
        }
	}
	protected override void UpdateMove()
	{
        base.UpdateMove();
        m_fireTimer = 2;       //每2秒射击一次
        if(m_player!=null)
        {
            //计算子弹初始方向，使其面向主角
            Vector3 relativePos = m_transform.position - m_player.position;
            Instantiate(m_rocket, m_transform.position, Quaternion.LookRotation(relativePos));  //创建子弹

        }
        //前进
        m_transform.Translate(new Vector3(0, 0, -m_speed * Time.deltaTime));
	}

}


