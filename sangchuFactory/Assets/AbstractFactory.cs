using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractFactory
{
    public SkillScriptableOBJ ClassSkils;
    public abstract void CharactorName();
    public abstract void CharactorSkill();
    public abstract void CharactorCustomize();
}
public class Mage : AbstractFactory
{
    public override void CharactorName()
    {
        Debug.Log(ClassSkils.classes[0].ClassName);
    }
    public override void CharactorSkill()
    {
        foreach (var item in ClassSkils.classes[0].SkillList)
        {
            Debug.Log(item.skillName);
        }
    }
    public override void CharactorCustomize()
    {
        
    }
}
public class SwordMan : AbstractFactory
{
    public override void CharactorName()
    {
        Debug.Log(ClassSkils.classes[1].ClassName);
    }
    public override void CharactorSkill()
    {
        foreach (var item in ClassSkils.classes[1].SkillList)
        {
            Debug.Log(item.skillName);
        }
    }
    public override void CharactorCustomize()
    {

    }
}
