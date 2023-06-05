using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactors : MonoBehaviour
{
    AbstractFactory ClassType;
    public void OnBTNClick()
    {
        switch (transform.name)
        {
            case "Mage": 
                ClassType = new Mage();
                ClassType.ClassSkils = Resources.Load<SkillScriptableOBJ>("data/skilDate");
                ClassType.CharactorName();
                ClassType.CharactorSkill();
                break;
            case "SwordMan": 
                ClassType = new SwordMan();
                ClassType.ClassSkils = Resources.Load<SkillScriptableOBJ>("data/skilDate");
                ClassType.CharactorName();
                ClassType.CharactorSkill();
                break;
        }
    }
}
