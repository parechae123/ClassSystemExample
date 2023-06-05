using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "skilData", menuName = "scOBJ/skilData", order = 1)]
public class SkillScriptableOBJ : ScriptableObject
{
    // Start is called before the first frame update

    public List<ClassType> classes = new List<ClassType>();
    
}
[System.Serializable]
public class ClassType
{
    public string ClassName = string.Empty;
    
    public SkillList[] SkillList;
}

[System.Serializable]
public class SkillList
{
    public string skillName = string.Empty;
    public string skillIcon = "SKillIcon";
    public string skillVFXPath = "SKillVFX";
}
