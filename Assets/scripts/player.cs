using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    
    protected Transform m_trasform;
    public Transform m_rocket;
    public float m_rocketTimer = 0;
    public float m_life = 3;
    public float m_speed = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.CompareTo("Enemy") == 0)
        //如果与主角子弹以外的碰撞体相撞
        {
            m_life -= 1;
            //减少生命
            if (m_life <= 0)
            {
                Destroy(this.gameObject); //自我销毁
            }
        }
    }
	
    // Use this for initialization
	void Start () {
        m_trasform = this.transform;
	}
	
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
        this.m_trasform.Translate( new Vector3(moveh, 0, movev));

        //子弹发射频率
        m_rocketTimer -= Time.deltaTime;
        if (m_rocketTimer <= 0)
        {
            m_rocketTimer = 0.1f;
       
          //按空格键或鼠标左键发射子弹
          if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)) 
           {
              Instantiate(m_rocket, m_trasform.position, m_trasform.rotation); //动态创建子弹游戏体
           }
        }

	}
}
