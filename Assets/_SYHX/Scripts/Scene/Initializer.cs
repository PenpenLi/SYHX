﻿using UnityEngine;
using System.Collections.Generic;
using SYHX.AbnormalStatus;
using SYHX.Cards;
using Sirenix.OdinInspector;
using SYHX.EnemyAI;

public class Initializer : SingletonMonoBehaviour<Initializer>
{
    [SerializeField] public List<AbnormalStatusSource> asSource;
    [SerializeField] public List<CardSource> cSource;
    [SerializeField] public List<EnemyActionSource> eaSource;
    [SerializeField] public DamageMono damageSource;
    [SerializeField] public List<Chapter> chapters;
    [SerializeField] public List<BattleHero> heroData;
    [SerializeField] public CharacterName umirika;
    [SerializeField] public BattleHero defaultHero;
    [SerializeField] public List<EnemyGroup> enemyGroup;
    [TableList] public ModificationFactor[] factors;
    [TableList] public LvInfo[] lvInfos;
    [TableList] public List<LvInfo> AttrLvInfos;

    public Language CurrentLanguage;


    protected override void UnityAwake()
    {
        GameObject.DontDestroyOnLoad(this);
        foreach (var card in cSource)
        {
            card.Init();
        }
        foreach (var abnormal in asSource)
        {
            abnormal.Init();
        }
        foreach (var action in eaSource)
        {
            action.Init();
        }
    }

    public BattleHero GetHero(CharacterContent cc)
    {
        foreach (var h in heroData)
        {
            if (h.Name == cc.Name)
            {
                return h;
            }
        }
        return defaultHero;
    }

    public void FadeIn()
    {
        StartCoroutine(Fade.Ins.FadeIn());
    }

    public void FadeOut()
    {
        StartCoroutine(Fade.Ins.FadeOut());
    }

    public void FadePingPong()
    {
        StartCoroutine(Fade.Ins.FadePingPong());
    }

    [System.Serializable]
    public class CharacterName
    {
        public string Name;
        public string ChineseName;
        public string JapaneseName;
    }
}

