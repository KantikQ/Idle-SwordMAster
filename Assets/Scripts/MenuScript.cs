using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public SkillScript skillScript;
    public TextMeshProUGUI SkillButtonTExt;
    public TextMeshProUGUI LanguageButtonText;
    public TextMeshProUGUI BossFightButtonText;

    public Button MenuButton;
    public Image MenuImage;

    public Button SkillButton;
    public Image SkillImage;

    public Button LanguageButton;
    public Image LanguageImage;

    public Button BossFightButton;
    public Image BossFightImage;

    // Start is called before the first frame update
    void Start()
    {
        MenuImage.gameObject.SetActive(false);
        SkillImage.gameObject.SetActive(false);
        LanguageImage.gameObject.SetActive(false);
        BossFightImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuOpen()
    {
        if (MenuImage.gameObject.activeSelf)
        {
            MenuImage.gameObject.SetActive(false);
        }
        else
        {
            MenuImage.gameObject.SetActive(true);
            SkillImage.gameObject.SetActive(false);
            LanguageImage.gameObject.SetActive(false);
            BossFightImage.gameObject.SetActive(false);
        }
    }

    public void SkillMenuOpen()
    {
        if (SkillImage.gameObject.activeSelf)
        {
            SkillImage.gameObject.SetActive(false);
        }
        else
        {
            SkillImage.gameObject.SetActive(true);
            MenuImage.gameObject.SetActive(false);
            LanguageImage.gameObject.SetActive(false);
            BossFightImage.gameObject.SetActive(false);
        }
        skillScript.SkillUpdate();
        skillScript.UpgradeButtonInteractable();
    }

    public void LanguageOpen()
    {
        if (LanguageImage.gameObject.activeSelf)
        {
            LanguageImage.gameObject.SetActive(false);
        }
        else
        {
            LanguageImage.gameObject.SetActive(true);
            SkillImage.gameObject.SetActive(false);
            MenuImage.gameObject.SetActive(false);
            BossFightImage.gameObject.SetActive(false);
        }
    }

    public void BossOpen()
    {
        if (BossFightImage.gameObject.activeSelf)
        {
            BossFightImage.gameObject.SetActive(false);
        }
        else
        {
            BossFightImage.gameObject.SetActive(true);
            LanguageImage.gameObject.SetActive(false);
            SkillImage.gameObject.SetActive(false);
            MenuImage.gameObject.SetActive(false);
        }
    }
}
