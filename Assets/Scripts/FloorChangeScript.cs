using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FloorChangeScript : MonoBehaviour
{
    public HeroScript Heroscript;

    public TextMeshProUGUI FloorText;
    public TextMeshProUGUI WorldText;

    public Button OpenFloorMenuButton;
    public Image FloorMenuImage;

    public int CurrentFloor = 1;
    public int FloorMaxUnlock = 1;
    public int FloorId = 1;

    public Button W1F1Button;
    public Button W1F2Button;
    public Button W1F3Button;
    public Button W1F4Button;
    public Button W1F5Button;
    public Button W1F6Button;
    public Button W1F7Button;
    void Start()
    {
        FloorMenuImage.gameObject.SetActive(false);

        W1F2Button.gameObject.SetActive(false);
        W1F3Button.gameObject.SetActive(false);
        W1F4Button.gameObject.SetActive(false);
        W1F5Button.gameObject.SetActive(false);
        W1F6Button.gameObject.SetActive(false);
        W1F7Button.gameObject.SetActive(false);
    }

    void Update()
    {
        
    }

    public void OpenFloorMenu()
    {
        if (FloorMenuImage.gameObject.activeSelf)
        {
            FloorMenuImage.gameObject.SetActive(false);
        }
        else
        {
            FloorMenuImage.gameObject.SetActive(true);
        }
    }

    public void FloorButtonChoose(int id)
    {
        if (id == 1)
        {
            FloorId = 1;
            W1F1Button.interactable = false;
            W1F2Button.interactable = true;
            W1F3Button.interactable = true;
            W1F4Button.interactable = true;
            W1F5Button.interactable = true;
            W1F6Button.interactable = true;
            W1F7Button.interactable = true;

        }
        else if (id == 2)
        {
            FloorId = 2;
            W1F2Button.interactable = false;
            W1F1Button.interactable = true;
            W1F3Button.interactable = true;
            W1F4Button.interactable = true;
            W1F5Button.interactable = true;
            W1F6Button.interactable = true;
            W1F7Button.interactable = true;
        }
        else if (id == 3)
        {
            FloorId = 3;
            W1F3Button.interactable = false;
            W1F2Button.interactable = true;
            W1F1Button.interactable = true;
            W1F4Button.interactable = true;
            W1F5Button.interactable = true;
            W1F6Button.interactable = true;
            W1F7Button.interactable = true;
        }
        else if (id == 4)
        {
            FloorId = 4;
            W1F1Button.interactable = true;
            W1F2Button.interactable = true;
            W1F3Button.interactable = true;
            W1F4Button.interactable = false;
            W1F5Button.interactable = true;
            W1F6Button.interactable = true;
            W1F7Button.interactable = true;
        }
        else if (id == 5)
        {
            FloorId = 5;
            W1F1Button.interactable = true;
            W1F2Button.interactable = true;
            W1F3Button.interactable = true;
            W1F4Button.interactable = true;
            W1F5Button.interactable = false;
            W1F6Button.interactable = true;
            W1F7Button.interactable = true;
        }
        else if (id == 6)
        {
            FloorId = 6;
            W1F1Button.interactable = true;
            W1F2Button.interactable = true;
            W1F3Button.interactable = true;
            W1F4Button.interactable = true;
            W1F5Button.interactable = true;
            W1F6Button.interactable = false;
            W1F7Button.interactable = true;
        }
        else if (id == 7)
        {
            FloorId = 7;
            W1F1Button.interactable = true;
            W1F2Button.interactable = true;
            W1F3Button.interactable = true;
            W1F4Button.interactable = true;
            W1F5Button.interactable = true;
            W1F6Button.interactable = true;
            W1F7Button.interactable = false;
        }
    }

    public void FloorDrop()
    {
        if (FloorId == 1)
        {
            int RandomFloor1Drop = Random.Range(2, 3);
            Heroscript.Bones += RandomFloor1Drop;
            Heroscript.EnemyDieCounterW1F1 += 1;
        }
        else if (FloorId == 2)
        {
            int RandomFloor2Drop = Random.Range(2, 4);
            Heroscript.ChampionAsh += RandomFloor2Drop;
            Heroscript.EnemyDieCounterW1F2 += 1;
            int RandomBonesDrop = Random.Range(0, 100);
            if (30 >= RandomBonesDrop)
            {
                Heroscript.Bones += 1;
            }
        }
        else if (FloorId == 3)
        {
            int RandomFloor3Drop = Random.Range(2, 3);
            Heroscript.BrokenSword += RandomFloor3Drop;
            Heroscript.EnemyDieCounterW1F3 += 1;
            int RandomAshDrop = Random.Range(0, 100);
            if (30 >= RandomAshDrop)
            {
                Heroscript.ChampionAsh += 1;
            }
        }
        else if (FloorId == 4)
        {
            int RandomFloor4Drop = Random.Range(3, 4);
            Heroscript.Banana += RandomFloor4Drop;
            Heroscript.EnemyDieCounterW1F4 += 1;
            int RandomSwordDrop = Random.Range(0, 100);
            if (30 >= RandomSwordDrop)
            {
                Heroscript.BrokenSword += 1;
            }
        }
        else if (FloorId == 5)
        {
            int RandomFloor5Drop = Random.Range(3, 4);
            Heroscript.BrokenHeart += RandomFloor5Drop;
            Heroscript.EnemyDieCounterW1F5 += 1;
            int RandomBananaDrop = Random.Range(0, 100);
            if (30 >= RandomBananaDrop)
            {
                Heroscript.Banana += 1;
            }
        }
        else if (FloorId == 6)
        {
            int RandomFloor6Drop = Random.Range(3, 4);
            Heroscript.Livs += RandomFloor6Drop;
            Heroscript.EnemyDieCounterW1F6 += 1;
            int RandomHeartDrop = Random.Range(0, 100);
            if (30 >= RandomHeartDrop)
            {
                Heroscript.BrokenHeart += 1;
            }
        }
        else if (FloorId == 7)
        {
            int RandomFloor7Drop = Random.Range(3, 4);
            Heroscript.Stick += RandomFloor7Drop;
            Heroscript.EnemyDieCounterW1F7 += 1;
            int RandomLivsDrop = Random.Range(0, 100);
            if (30 >= RandomLivsDrop)
            {
                Heroscript.Livs += 1;
            }
        }
    }

    public void FloorUnlock()
    {
        if (Heroscript.EnemyDieCounterW1F1 == 5)
        {
            W1F2Button.gameObject.SetActive(true);
        }
        else if (Heroscript.EnemyDieCounterW1F2 == 10)
        {
            W1F3Button.gameObject.SetActive(true);
        }
        else if (Heroscript.EnemyDieCounterW1F3 == 15)
        {
            W1F4Button.gameObject.SetActive(true);
        }
        else if (Heroscript.EnemyDieCounterW1F4 == 20)
        {
            W1F5Button.gameObject.SetActive(true);
        }
        else if (Heroscript.EnemyDieCounterW1F5 == 25)
        {
            W1F6Button.gameObject.SetActive(true);
        }
        else if (Heroscript.EnemyDieCounterW1F6 == 30)
        {
            W1F7Button.gameObject.SetActive(true);
        }
    }
}
