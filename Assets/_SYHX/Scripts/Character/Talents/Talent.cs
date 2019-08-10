﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Talent : ScriptableObject
{
    public Talent() { }

    //是否初始就已经解锁
    public bool IsUnlock;
    public TalentGroup Owner;
    public string Name;
    public string Desc;
    public Sprite Icon;

    public virtual void OnActive()
    {
    }

}