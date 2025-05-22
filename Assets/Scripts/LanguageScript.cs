using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageScript : MonoBehaviour
{
    public SkillScript skillScript;
    public MenuScript menuScript;
    public FloorChangeScript floorChangeScript;
    public BossAttackScript bossAttackScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLanguage(string id)
    {
        if (id == "ru")
        {
            floorChangeScript.FloorText.text = "Уровень";
            floorChangeScript.WorldText.text = "Мир";

            menuScript.SkillButtonTExt.text = "Умения";
            menuScript.LanguageButtonText.text = "Язык";
            menuScript.BossFightButtonText.text = "Босс";

            skillScript.Skill1Name.text = "Улучшение Силы";
            skillScript.Skill2Name.text = "Улучшение здоровья";
            skillScript.Skill3Name.text = "Шанс критического Удара";

            bossAttackScript.BossButtonFightText.text = "Атаковать";
        }
        else if (id == "en")
        {
            floorChangeScript.FloorText.text = "Level";
            floorChangeScript.WorldText.text = "World";

            menuScript.SkillButtonTExt.text = "Skill";
            menuScript.LanguageButtonText.text = "Language";
            menuScript.BossFightButtonText.text = "Boss";

            skillScript.Skill1Name.text = "Power Upgrade";
            skillScript.Skill2Name.text = "Health Upgrade";
            skillScript.Skill3Name.text = "The Chance of a Critical Hit";

            bossAttackScript.BossButtonFightText.text = "Attack";
        }
        else if (id == "tur")
        {
            floorChangeScript.FloorText.text = "Düzey";
            floorChangeScript.WorldText.text = "Dünya";

            menuScript.SkillButtonTExt.text = "Beceriler";
            menuScript.LanguageButtonText.text = "Dil";
            menuScript.BossFightButtonText.text = "Patron";

            skillScript.Skill1Name.text = "Gücün İyileştirilmesi";
            skillScript.Skill2Name.text = "Sağlığın iyileştirilmesi";
            skillScript.Skill3Name.text = "Kritik Vuruş Şansı";

            bossAttackScript.BossButtonFightText.text = "Saldırı";
        }
        else if (id == "germ")
        {
            floorChangeScript.FloorText.text = "Ebene";
            floorChangeScript.WorldText.text = "Welt";

            menuScript.SkillButtonTExt.text = "Faehigkeit";
            menuScript.LanguageButtonText.text = "Sprache";
            menuScript.BossFightButtonText.text = "Chef";

            skillScript.Skill1Name.text = "Verbesserung der Stärke";
            skillScript.Skill2Name.text = "Verbesserung der Gesundheit";
            skillScript.Skill3Name.text = "Kritische Trefferchance";

            bossAttackScript.BossButtonFightText.text = "Angriff";
        }
        else if (id == "espan")
        {
            floorChangeScript.FloorText.text = "Nivel";
            floorChangeScript.WorldText.text = "Mundo";

            menuScript.SkillButtonTExt.text = "Habilidades";
            menuScript.LanguageButtonText.text = "Idioma";
            menuScript.BossFightButtonText.text = "Jefe";

            skillScript.Skill1Name.text = "Mejora De La Fuerza";
            skillScript.Skill2Name.text = "Mejorar la salud";
            skillScript.Skill3Name.text = "Posibilidad de Golpe crítico";

            bossAttackScript.BossButtonFightText.text = "Ataque";
        }
    }
}
