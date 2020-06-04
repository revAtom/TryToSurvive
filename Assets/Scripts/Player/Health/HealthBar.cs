﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Image ImgHealthBar;

    public Text TxtHealth;

    public int Min;
    public int Max;

    public int mCurrentValue;
    public float mCurrentPercent;

    public void SetHealth(int health)
    {   
        if (health != mCurrentValue)
        {
            if (Max - Min == 0)
            {
                mCurrentValue = 0;
                mCurrentPercent = 0;
            }
            else
            {
                mCurrentValue = health;
                mCurrentPercent = (float)mCurrentValue / (float)(Max - Min);
            }

        }
    }

    private void Update()
    {

        TxtHealth.text = string.Format("{0} %", Mathf.RoundToInt(mCurrentPercent * 100));

        ImgHealthBar.fillAmount = mCurrentPercent;
    }

    public float CurrentPercent 
            {
                 get { return mCurrentPercent; }
            }
            
            public float CurrentValue 
            {
                 get { return mCurrentValue; }
            }

    void Start()
    {
        SetHealth(41);
    }
}

