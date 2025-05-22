using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.UI;

public class SkillScript : MonoBehaviour
{
    public HeroScript Heroscript;
    public Button Skill1ButtonUp;
    public TextMeshProUGUI Skill1Name;
    public TextMeshProUGUI Skill1TextValue;
    public TextMeshProUGUI Skill1TextCost;
    public TextMeshProUGUI Skill1NumberText;
    public Image Skill1Image;
    public Sprite[] Skill1image;

    public int Skill1DamageMin = 0;
    public int Skill1DamageMax = 1;
    public int Skill1Cost = 2;
    public int Skill1NumberMin = 0;
    public int Skill1NumberMax = 90;

    public Button Skill2Button;
    public TextMeshProUGUI Skill2Name;
    public TextMeshProUGUI Skill2TextValue;
    public TextMeshProUGUI Skill2TextCost;
    public TextMeshProUGUI Skill2NumberText;
    public Image Skill2Image;

    public int Skill2HealthMin = 0;
    public int Skill2HealthMax = 3;
    public int Skill2Cost = 5;
    public int HeroHealthCurrentSkill = 10;
    public int HeroHealthCurrentSkillMax = 10;
    public int Skill2NumberMin = 0;
    public int Skill2NumberMax = 90;

    public Button Skill3Button;
    public TextMeshProUGUI Skill3Name;
    public TextMeshProUGUI Skill3TextValue;
    public TextMeshProUGUI Skill3TextCost;
    public TextMeshProUGUI Skill3NumberText;

    public int SKill3CritChanceMin = 0;
    public int Skill3CritChanceMax = 1;
    public int SKill3Cost = 25;
    public int Skill3NumberMin = 0;
    public int Skill3NumberMax = 10;

    void Start()
    {
        SkillUpdate();
        UpdateImageRes();
        Skill3Update();
    }

    void Update()
    {
        
    }

    public void SkillUpgrade()
    {
        if (Heroscript.Bones >= Skill1Cost & Skill1NumberMin <= 5)
        {
            Skill1Image.sprite = Skill1image[0];
            Heroscript.Bones -= Skill1Cost;
            Skill1Cost += 1;
            Skill1DamageMin += 1;
            Skill1DamageMax += 1;
            Skill1NumberMin += 1;
        }
        else if (Heroscript.ChampionAsh >= Skill1Cost & Skill1NumberMin <= 10 & Skill1NumberMin > 5)
        {
            Skill1Image.sprite = Skill1image[1];
            Heroscript.ChampionAsh -= Skill1Cost;
            Skill1Cost += 1;
            Skill1DamageMin += 1;
            Skill1DamageMax += 1;
            Skill1NumberMin += 1;
        }
        else if (Heroscript.BrokenSword >= Skill1Cost & Skill1NumberMin > 10 & Skill1NumberMin <= 15)
        {
            Skill1Image.sprite = Skill1image[2];
            Heroscript.BrokenSword -= Skill1Cost;
            Skill1Cost += 1;
            Skill1DamageMin += 1;
            Skill1DamageMax += 1;
            Skill1NumberMin += 1;
        }
        else if (Heroscript.Banana >= Skill1Cost & Skill1NumberMin > 15 & Skill1NumberMin <= 20)
        {
            Skill1Image.sprite = Skill1image[3];
            Heroscript.Banana -= Skill1Cost;
            Skill1Cost += 1;
            Skill1DamageMin += 1;
            Skill1DamageMax += 1;
            Skill1NumberMin += 1;
        }
        else if (Heroscript.BrokenHeart >= Skill1Cost & Skill1NumberMin > 20 & Skill1NumberMin <= 25)
        {
            Skill1Image.sprite = Skill1image[4];
            Heroscript.BrokenHeart -= Skill1Cost;
            Skill1Cost += 1;
            Skill1DamageMin += 1;
            Skill1DamageMax += 1;
            Skill1NumberMin += 1;
        }
        else if (Heroscript.Livs >= Skill1Cost & Skill1NumberMin > 25 & Skill1NumberMin <= 30)
        {
            Skill1Image.sprite = Skill1image[5];
            Heroscript.Livs -= Skill1Cost;
            Skill1Cost += 1;
            Skill1DamageMin += 1;
            Skill1DamageMax += 1;
            Skill1NumberMin += 1;
        }
        else if (Heroscript.Stick >= Skill1Cost & Skill1NumberMin > 30 & Skill1NumberMin <= 35)
        {
            Skill1Image.sprite = Skill1image[6];
            Heroscript.Stick -= Skill1Cost;
            Skill1Cost += 1;
            Skill1DamageMin += 1;
            Skill1DamageMax += 1;
            Skill1NumberMin += 1;
        }
        SkillUpdate();
        UpgradeButtonInteractable();
        UpdateImageRes();
    }

    public void Skill2Upgrade()
    {
        if (Heroscript.Bones >= Skill2Cost & Skill2NumberMin <= 5)
        {
            Skill2Image.sprite = Skill1image[0];
            Heroscript.Bones -= Skill2Cost;
            Skill2Cost += 3;
            Skill2HealthMin += 3;
            Skill2HealthMax += 3;
            Skill2NumberMin += 1;
            HeroHealthCurrentSkillMax = Heroscript.HeroHealthCurrent + Skill2HealthMin;
        }
        else if (Heroscript.ChampionAsh >= Skill2Cost & Skill2NumberMin <= 10 & Skill2NumberMin > 5)
        {
            Skill2Image.sprite = Skill1image[1];
            Heroscript.ChampionAsh -= Skill2Cost;
            Skill2Cost += 3;
            Skill2HealthMin += 3;
            Skill2HealthMax += 3;
            Skill2NumberMin += 1;
            HeroHealthCurrentSkillMax = Heroscript.HeroHealthCurrent + Skill2HealthMin;
        }
        else if (Heroscript.BrokenSword >= Skill2Cost & Skill2NumberMin > 10 & Skill2NumberMin <= 15)
        {
            Skill2Image.sprite = Skill1image[2];
            Heroscript.BrokenSword -= Skill2Cost;
            Skill2Cost += 3;
            Skill2HealthMin += 3;
            Skill2HealthMax += 3;
            Skill2NumberMin += 1;
            HeroHealthCurrentSkillMax = Heroscript.HeroHealthCurrent + Skill2HealthMin;
        }
        else if (Heroscript.Banana >= Skill2Cost & Skill2NumberMin > 15 & Skill2NumberMin <= 20)
        {
            Skill2Image.sprite = Skill1image[3];
            Heroscript.Banana -= Skill2Cost;
            Skill2Cost += 3;
            Skill2HealthMin += 3;
            Skill2HealthMax += 3;
            Skill2NumberMin += 1;
            HeroHealthCurrentSkillMax = Heroscript.HeroHealthCurrent + Skill2HealthMin;
        }
        else if (Heroscript.BrokenHeart >= Skill2Cost & Skill2NumberMin > 20 & Skill2NumberMin <= 25)
        {
            Skill2Image.sprite = Skill1image[4];
            Heroscript.BrokenHeart -= Skill2Cost;
            Skill2Cost += 3;
            Skill2HealthMin += 3;
            Skill2HealthMax += 3;
            Skill2NumberMin += 1;
            HeroHealthCurrentSkillMax = Heroscript.HeroHealthCurrent + Skill2HealthMin;
        }
        else if (Heroscript.Livs >= Skill2Cost & Skill2NumberMin > 25 & Skill2NumberMin <= 30)
        {
            Skill2Image.sprite = Skill1image[5];
            Heroscript.Livs -= Skill2Cost;
            Skill2Cost += 3;
            Skill2HealthMin += 3;
            Skill2HealthMax += 3;
            Skill2NumberMin += 1;
            HeroHealthCurrentSkillMax = Heroscript.HeroHealthCurrent + Skill2HealthMin;
        }
        else if (Heroscript.Stick >= Skill2Cost & Skill2NumberMin > 30 & Skill2NumberMin <= 35)
        {
            Skill2Image.sprite = Skill1image[6];
            Heroscript.Stick -= Skill2Cost;
            Skill2Cost += 3;
            Skill2HealthMin += 3;
            Skill2HealthMax += 3;
            Skill2NumberMin += 1;
            HeroHealthCurrentSkillMax = Heroscript.HeroHealthCurrent + Skill2HealthMin;
        }
        SkillUpdate();
        UpgradeButtonInteractable();
        UpdateImageRes();
    }

    public void Skill3Upgarde()
    {
        if (Heroscript.ChampionAsh >= SKill3Cost & Skill3NumberMin != Skill3NumberMax)
        {
            Heroscript.ChampionAsh -= SKill3Cost;
            SKill3Cost += 10 + Skill3CritChanceMax;
            SKill3CritChanceMin += Skill3CritChanceMax;
            Skill3CritChanceMax += 1;
            Skill3NumberMin += 1;
        }
        else if (Skill3NumberMin == Skill3NumberMax)
        {
            Skill3Button.interactable = false;
            Skill3TextValue.text = "-/-";
            Skill3TextCost.text = "-/-";
        }
        Skill3Update();
    }

    public void SkillUpdate()
    {     
        Skill1TextValue.text = Skill1DamageMin + " -> " + Skill1DamageMax;   
        Skill1NumberText.text = Skill1NumberMin + "/" + Skill1NumberMax;

        Skill2TextValue.text = Skill2HealthMin + " -> " + Skill2HealthMax;
        Skill2NumberText.text = Skill2NumberMin + "/" + Skill2NumberMax;


        if (Skill1NumberMin <= 5)
        {
            Skill1TextCost.text = Heroscript.Bones + "/" + Skill1Cost;
        }
        else if (Skill1NumberMin <= 10)
        {
            Skill1TextCost.text = Heroscript.ChampionAsh + "/" + Skill1Cost;
        }
        else if (Skill1NumberMin <= 15)
        {
            Skill1TextCost.text = Heroscript.BrokenSword + "/" + Skill1Cost;
        }
        else if (Skill1NumberMin <= 20)
        {
            Skill1TextCost.text = Heroscript.Banana + "/" + Skill1Cost;
        }
        else if (Skill1NumberMin <= 25)
        {
            Skill1TextCost.text = Heroscript.BrokenHeart + "/" + Skill1Cost;
        }
        else if (Skill1NumberMin <= 30)
        {
            Skill1TextCost.text = Heroscript.Livs + "/" + Skill1Cost;
        }
        else if (Skill1NumberMin <= 35)
        {
            Skill1TextCost.text = Heroscript.Stick + "/" + Skill1Cost;
        }

        if (Skill2NumberMin <= 5)
        {
            Skill2TextCost.text = Heroscript.Bones + "/" + Skill2Cost;
        }
        else if (Skill2NumberMin <= 10)
        {
            Skill2TextCost.text = Heroscript.ChampionAsh + "/" + Skill2Cost;
        }
        else if (Skill2NumberMin <= 15)
        {
            Skill2TextCost.text = Heroscript.BrokenSword + "/" + Skill2Cost;
        }
        else if (Skill2NumberMin <= 20)
        {
            Skill2TextCost.text = Heroscript.Banana + "/" + Skill2Cost;
        }
        else if (Skill2NumberMin <= 25)
        {
            Skill2TextCost.text = Heroscript.BrokenHeart + "/" + Skill2Cost;
        }
        else if (Skill2NumberMin <= 30)
        {
            Skill2TextCost.text = Heroscript.Livs + "/" + Skill2Cost;
        }
        else if (Skill2NumberMin <= 35)
        {
            Skill2TextCost.text = Heroscript.Stick + "/" + Skill2Cost;
        }
    }

    public void Skill3Update()
    {
        Skill3TextValue.text = SKill3CritChanceMin + "% -> " + Skill3CritChanceMax + "%";
        Skill3TextCost.text = Heroscript.ChampionAsh + "/" + SKill3Cost;
        Skill3NumberText.text = Skill3NumberMin + "/" + Skill3NumberMax; 
    }

    public void UpgradeButtonInteractable()
    {
        Skill1ButtonUp.interactable = Heroscript.Bones >= Skill1Cost || Heroscript.ChampionAsh >= Skill1Cost || Heroscript.BrokenSword >= Skill1Cost || Heroscript.Banana >= Skill1Cost || Heroscript.BrokenHeart >= Skill1Cost || Heroscript.Livs >= Skill1Cost || Heroscript.Stick >= Skill1Cost;

        Skill2Button.interactable = Heroscript.Bones >= Skill2Cost || Heroscript.ChampionAsh >= Skill2Cost || Heroscript.BrokenSword >= Skill2Cost || Heroscript.Banana >= Skill2Cost || Heroscript.BrokenHeart >= Skill2Cost || Heroscript.Livs >= Skill2Cost || Heroscript.Stick >= Skill2Cost;

        Skill3Button.interactable = Heroscript.ChampionAsh >= SKill3Cost;
    }

    public void UpdateImageRes()
    {
        if (Skill1NumberMin <= 5)
        {
            Skill1Image.sprite = Skill1image[0];
        }
        else if (Skill1NumberMin <= 10)
        {
            Skill1Image.sprite = Skill1image[1];
        }
        else if (Skill1NumberMin <= 15)
        {
            Skill1Image.sprite = Skill1image[2];
        }
        else if (Skill1NumberMin <= 20)
        {
            Skill1Image.sprite = Skill1image[3];
        }
        else if (Skill1NumberMin <= 25)
        {
            Skill1Image.sprite = Skill1image[4];
        }
        else if (Skill1NumberMin <= 30)
        {
            Skill1Image.sprite = Skill1image[5];
        }
        else if (Skill1NumberMin <= 35)
        {
            Skill1Image.sprite = Skill1image[6];
        }

        if (Skill2NumberMin <= 5)
        {
            Skill2Image.sprite = Skill1image[0];
        }
        else if (Skill2NumberMin <= 10)
        {
            Skill2Image.sprite = Skill1image[1];
        }
        else if (Skill2NumberMin <= 15)
        {
            Skill2Image.sprite = Skill1image[2];
        }
        else if (Skill2NumberMin <= 20)
        {
            Skill2Image.sprite = Skill1image[3];
        }
        else if (Skill2NumberMin <= 25)
        {
            Skill2Image.sprite = Skill1image[4];
        }
        else if (Skill2NumberMin <= 30)
        {
            Skill2Image.sprite = Skill1image[5];
        }
        else if (Skill2NumberMin <= 35)
        {
            Skill2Image.sprite = Skill1image[6];
        }
    }
}
