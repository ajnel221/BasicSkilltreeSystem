using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillUpgrader : MonoBehaviour
{
    public Text[] skillsTexts;
    public Button[] skillButtons;
    public Image[] levelImages;

    private void Update()
    {
        UpdateFireballText();
        UpdateFireball2Text();
        UpdateLightningText();
        UpdateLightning2Text();
        LeftOverPoints();
        ValueChecker();
    }


    public void ValueChecker()
    {
        if(LevelCounter.fireballLevelCounter == 5)
        {
            skillButtons[0].enabled = false;
            skillButtons[2].enabled = true;
            levelImages[0].color = Color.green;
        }

        else
        {
            skillButtons[0].enabled = true;
            skillButtons[2].enabled = false;
            levelImages[0].color = Color.red;
        }

        if(LevelCounter.lightningLevelCounter == 5)
        {
            skillButtons[1].enabled = false;
            skillButtons[3].enabled = true;
            levelImages[1].color = Color.green;
        }

        else
        {
            skillButtons[1].enabled = true;
            skillButtons[3].enabled = false;
            levelImages[1].color = Color.red;
        }
    }



/*____________________________________________________Fireball Skill____________________________________________________*/

    public void UpgradeFireballLevel()
    {
        if(LevelCounter.remainingSkillPoints > 0 && LevelCounter.fireballLevelCounter < 5)
        {
            LevelCounter.fireballLevelCounter++;
        }

        else
        {
            Debug.Log("No More Points To Spend!");
        }
    }

    private void UpdateFireballText()
    {
        skillsTexts[0].text = LevelCounter.fireballLevelCounter.ToString();
    }

    /*____________________________________________________Fireball Skill Level 2____________________________________________________*/

    public void UpgradeFireballLevel2()
    {
        if(LevelCounter.remainingSkillPoints > 0 && LevelCounter.fireballLevelCounter == 5)
        {
            LevelCounter.fireballLevelCounter2++;
        }

        else
        {
            Debug.Log("No More Points To Spend!");
        }

        if(LevelCounter.fireballLevelCounter == 5)
        {
            skillButtons[0].enabled = false;
        }
    }

    private void UpdateFireball2Text()
    {
        skillsTexts[3].text = LevelCounter.fireballLevelCounter2.ToString();
    }


    /*____________________________________________________Lightning Skill____________________________________________________*/

    public void UpgradeLightningLevel()
    {
        if(LevelCounter.remainingSkillPoints > 0  && LevelCounter.lightningLevelCounter < 5)
        {
            LevelCounter.lightningLevelCounter++;
        }

        else
        {
            Debug.Log("No More Points To Spend!");
        }
    }

    private void UpdateLightningText()
    {
        skillsTexts[2].text = LevelCounter.lightningLevelCounter.ToString();
    }


    /*____________________________________________________Lightning Skill____________________________________________________*/

    public void UpgradeLightningLevel2()
    {
        if(LevelCounter.remainingSkillPoints > 0 && LevelCounter.lightningLevelCounter == 5)
        {
            LevelCounter.lightningLevelCounter2++;
        }

        else
        {
            Debug.Log("No More Points To Spend!");
        }
    }

    private void UpdateLightning2Text()
    {
        skillsTexts[4].text = LevelCounter.lightningLevelCounter2.ToString();
    }



    /*____________________________________________________Remove Points____________________________________________________*/

    public void RemoveSkillPoints()
    {
        if(LevelCounter.remainingSkillPoints > 0)
        {
            LevelCounter.remainingSkillPoints--;
        }

        else
        {
            Debug.Log("No More Points To Spend");
        }
    }

    private void LeftOverPoints()
    {
        skillsTexts[1].text = LevelCounter.remainingSkillPoints.ToString();
    }
}
