using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superenemy : MonoBehaviour {
    protected Transform m_transform;
    public float m_speed = 1;         //速度
    public float m_life = 1;           //生命
    protected float m_rotspeed = 30;  //旋转速度
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.CompareTo("PlayRocket") == 0)  //如果撞到主角子弹
        {
            rocket rocket = other.GetComponent<rocket>();//获得子弹上的rocket脚本组件
            if (rocket != null)
            {
                m_life -= rocket.m_power;  //减少生命
                if (m_life <= 0)
                {
                    Destroy(this.gameObject);  //自我销毁
                }
            }
        }
        else if (other.tag.CompareTo("Player") == 0)  //如果撞到主角
        {
            m_life = 0;
            Destroy(this.gameObject);  //自我销毁
        }
    }

    internal Renderer m_renderer;   //模型渲染组件
    internal bool m_isActiv = false; //是否激活

    // Use this for initialization
    void Start()
    {
        m_transform = this.transform;
        m_renderer = this.GetComponent<Renderer>();  //获得渲染模型组件
    }
    private void OnBecameVisible()  //当模型进入屏幕
    {
        m_isActiv = true;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMove();
        if (m_isActiv && !this.m_renderer.isVisible)  //如果移动到屏幕外
        {
            Destroy(this.gameObject);  //自我销毁
        }
    }
    protected virtual void UpdateMove()
    {
      //前进
        m_transform.Translate(new Vector3(0, 0, -m_speed * Time.deltaTime));

    }
    
}
