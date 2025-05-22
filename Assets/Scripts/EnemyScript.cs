using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    private Animator animator;
    public HeroScript Heroscript;
    public SkillScript skillScript;
    public FloorChangeScript floorChangeScript;

    public Sprite[] EnemyImage;
    public Image Enemyimage;
    public TextMeshProUGUI EnemyHpText;

    public Slider EnemyHpSlider;

    public int EnemyHealthCurrent = 5;
    public int EnemyMaxHealth = 5;

    public int TimerAttack = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(EnemyAttackTime());
        EnemyHpSliderUpdate();
    }

    void Update()
    {
        
    }

    public void EnemyDie()
    {
        if (EnemyHealthCurrent <= 0)
        {
            //Heroscript.GoldDrop();
            floorChangeScript.FloorDrop();
            Heroscript.XpDrop();
            EnemyHealthCurrent = 0;

            EnemyHealthCurrent = EnemyMaxHealth;
            int RandomEnemySkin = Random.Range(0, 4);
            Enemyimage.sprite = EnemyImage[RandomEnemySkin];
            skillScript.UpgradeButtonInteractable();
            skillScript.SkillUpdate();          
        }
    }

    public void EnemyHpSliderUpdate()
    {
        EnemyHpSlider.value = EnemyHealthCurrent;
        EnemyHpSlider.maxValue = EnemyMaxHealth;
    }

    public void EnemyTextUpdate()
    {
        EnemyHpText.text = EnemyHealthCurrent + "/" + EnemyMaxHealth;
    }

    public IEnumerator EnemyAttackTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            TimerAttack += 1;
            if (TimerAttack == 6)
            {
                TimerAttack = 0;
                animator.SetTrigger("EnemyAttack");
                skillScript.HeroHealthCurrentSkill -= 1;
            }
            Heroscript.updateUi();
            Heroscript.HeroDie();
            Heroscript.SliderHeroHealth();
        }
    }
}
