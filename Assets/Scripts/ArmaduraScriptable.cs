using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName="Objects/Armor", fileName = "New Armor")]
public class ArmaduraScriptable : ScriptableObject
{
    public string armorName;
    public string armorDescription;
    public int armorLevel;
    public int armorDefense;
    public Sprite armorImage;
}
