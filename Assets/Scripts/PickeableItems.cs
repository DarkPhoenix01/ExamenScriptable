using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickeableItems : MonoBehaviour
{
    public ArmasScriptable Weapon;
    public ArmaduraScriptable Armor;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player" && this.gameObject.tag == "Weapon") 
        {
            Inventario.Instance.AddArma(Weapon);
            Destroy(gameObject);

        }else if(other.gameObject.tag == "Player" && this.gameObject.tag == "Armor")
        {
            Inventario.Instance.AddArmadura(Armor);
            Destroy(gameObject);

        }
    }
}
