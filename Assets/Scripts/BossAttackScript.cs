using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BossAttackScript : MonoBehaviour
{
    public HeroScript Heroscript;
    public SkillScript skillScript;

    public TextMeshProUGUI BossButtonFightText;

    public TextMeshProUGUI BossArmorText;
    public TextMeshProUGUI BossDamageText;
    public TextMeshProUGUI BossHpText;

    public TextMeshProUGUI PlayerDamageText;
    public TextMeshProUGUI PlayerHpText;

    public Slider BossHpSlider;
    public Slider PLayerHpSlider;

    public int BossHpMax = 25;
    public int BossCurrentHp = 25;
    public int BossDamage = 5;
    public int BossArmor = 5;

    public int BossId = 0;

    public int PlayerCurrentHp = 10;
    public int PlayerHpMax = 10;

    public int TimerAttack = 0;

    void Start()
    {
        StatUpdate();
    }

    void Update()
    {
        
    }

    public void BossButtonFight()
    {
        if (BossCurrentHp > 0)
        {
            TimerAttack += 1;
            if (TimerAttack == 5)
            {
                TimerAttack = 0;
                BossCurrentHp -= Heroscript.HeroAllDamage;
            }
        }
        else if (BossCurrentHp <= 0)
        {
            BossCurrentHp = 0;
            BossCurrentHp = BossHpMax;
            BossDie0();
        }
    }

    public void StatUpdate()
    {
        BossArmorText.text = BossArmor + ":";
        BossDamageText.text = BossDamage + ":";
        BossHpText.text = BossCurrentHp + " / " + BossHpMax;

        PlayerHpText.text = PlayerCurrentHp + " / " + PlayerHpMax;
        PlayerDamageText.text = Heroscript.HeroAllDamage + ":";
    }

    public void BossDie0()
    {
        
    }
}
