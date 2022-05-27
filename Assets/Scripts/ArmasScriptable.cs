using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName="Objects/Weapon", fileName = "New Weapon")]
public class ArmasScriptable : ScriptableObject
{
    public string weaponName;
    public string weaponDescription;
    public int weaponLevel;
    public int weaponAttack;
    public Sprite weaponImage;
}
