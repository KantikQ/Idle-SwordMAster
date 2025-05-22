using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HeroScript : MonoBehaviour
{
    private Animator animator;
    public EnemyScript enemyScript;
    public SkillScript skillScript;
    public FloorChangeScript floorChangeScript;

    public int HeroHealthCurrent = 10;
    public int HeroMaxHealth = 10;
    public int HeroDamage = 1;
    public int HeroAllDamage = 0;

    public TextMeshProUGUI HeroHealthText;

    public Slider HeroHealthSlider;

    public int Gold = 0;
    public TextMeshProUGUI GoldText;

    public Slider HeroAttackTimer;
    public int HeroTimeAttackMax = 5;
    public int HeroTimeAttackMin = 0;

    public Slider HeroXpSlider;
    public int XpValue = 0;
    public int XpMaxValue = 10;

    public int LevelPlayer = 0;
    public int LevelPoint = 0;

    public int EnemyDieCounterW1F1 = 0;
    public int EnemyDieCounterW1F2 = 0;
    public int EnemyDieCounterW1F3 = 0;
    public int EnemyDieCounterW1F4 = 0;
    public int EnemyDieCounterW1F5 = 0;
    public int EnemyDieCounterW1F6 = 0;
    public int EnemyDieCounterW1F7 = 0;

    public TextMeshProUGUI LevelText;

    //EnemyDropFloor//

    public int Bones = 0;
    public int ChampionAsh = 0;
    public int BrokenSword = 0;
    public int Banana = 0;
    public int BrokenHeart = 0;
    public int Livs = 0;
    public int Stick = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        enemyScript.EnemyHpSliderUpdate();
        enemyScript.EnemyTextUpdate();
        StartCoroutine(HeroAttackTime());
        StartCoroutine(Timer());
        updateUi();
        SliderHeroHealth();
        XpSlider();
        floorChangeScript.FloorUnlock();
    }

    void Update()
    {
        
    }

    public IEnumerator HeroAttackTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(HeroTimeAttackMax);
            animator.SetTrigger("HeroAttack");
            int CritRandom = Random.Range(0, 100);
            if (skillScript.SKill3CritChanceMin >= CritRandom)
            {
                enemyScript.EnemyHealthCurrent -= (HeroDamage + skillScript.Skill1DamageMin) * 2;
            }
            else
            {
                enemyScript.EnemyHealthCurrent -= HeroDamage + skillScript.Skill1DamageMin;
            }
            enemyScript.EnemyDie();
            enemyScript.EnemyHpSliderUpdate();
            enemyScript.EnemyTextUpdate();
            HeroAllDamage = HeroDamage + skillScript.Skill1DamageMin;
            updateUi();
            Debug.Log(enemyScript.EnemyHealthCurrent);
        }
    }

    public IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            SliderHeroAttack();
            UpdateSliderHeroAttck();
        }
    }

    public void HeroDie()
    {
        if (skillScript.HeroHealthCurrentSkill <= 0)
        {
            skillScript.HeroHealthCurrentSkill = 0;
            skillScript.HeroHealthCurrentSkill = skillScript.HeroHealthCurrentSkillMax;
        }
    }

    public void GoldDrop()
    {
        Gold += 1;
    }

    public void updateUi()
    {
        GoldText.text = Gold + " :";
        HeroHealthText.text = skillScript.HeroHealthCurrentSkill + "/" + skillScript.HeroHealthCurrentSkillMax;
        LevelText.text = LevelPlayer + "";
        XpSlider();
        floorChangeScript.FloorUnlock();
    }

    public void SliderHeroAttack()
    {
        HeroAttackTimer.maxValue = HeroTimeAttackMax;
        HeroAttackTimer.value = HeroTimeAttackMin;
    }

    public void SliderHeroHealth()
    {
        HeroHealthSlider.maxValue = skillScript.HeroHealthCurrentSkillMax;
        HeroHealthSlider.value = skillScript.HeroHealthCurrentSkill;
    }

    public void UpdateSliderHeroAttck()
    {
        HeroTimeAttackMin += 1;
        if (HeroTimeAttackMin == HeroTimeAttackMax)
        {
            HeroTimeAttackMin = 0;
        }
    }

    public void XpSlider()
    {
        HeroXpSlider.value = XpValue;
        HeroXpSlider.maxValue = XpMaxValue;
    }

    public void XpDrop()
    {
        int RandomXpDrop = Random.Range(1, 2);
        XpValue += RandomXpDrop;
        if (XpValue >= XpMaxValue)
        {
            XpValue = 0;
            XpMaxValue *= 2;
            LevelPlayer += 1;
            LevelPoint += 1;
            XpSlider();
        }
    }
}
