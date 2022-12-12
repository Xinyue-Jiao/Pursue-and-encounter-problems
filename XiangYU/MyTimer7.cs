﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyTimer7 : MonoBehaviour
{


    public static float m_Timer;
    public static bool isPause = false;
    public static bool isStart = false;
    public int m_Hour;//时
    public int m_Minute;//分
    public static int m_Second;//秒
                               // public static float Order[4]

    // Start is called before the first frame update
    void Start()
    {
        m_Timer = 0;
        isStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart == true)
        {
            if (!isPause)
            {

                m_Timer += Time.deltaTime;
                m_Second = (int)m_Timer;
                if (m_Second > 59.99f)
                {
                    m_Second = (int)(m_Timer - (m_Minute * 60));
                }
                m_Minute = (int)(m_Timer / 60);
                if (m_Minute > 59.99f)
                {
                    m_Minute = (int)(m_Minute - (m_Hour * 60));
                }
                m_Hour = m_Minute / 60;
                if (m_Hour >= 24.0f)
                {
                    m_Timer = 0;
                }
                // this.GetComponent<Text>().text = string.Format("{0:d2}:{1:d2}:{2:d2}", m_Hour, m_Minute, m_Second);
                this.GetComponent<Text>().text = string.Format("{0:f0}", m_Timer) + "s";
            }
            else
            {
                //this.GetComponent<Text>().text = string.Format("{0:d2}:{1:d2}:{2:d2}", m_Hour, m_Minute, m_Second);
                this.GetComponent<Text>().text = string.Format("{0:f0}", m_Timer) + "s";

            }

        }
        else
        {
            this.GetComponent<Text>().text = "00:00";
        }



    }

}
