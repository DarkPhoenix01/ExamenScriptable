using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public static Inventario Instance;

    public ArmasScriptable[] armas;
    public Text[] nombreArma;
    public Text[] descripcionArma;
    public Image[] imagenArma;
    public Text[] DpsArma;
    public Text[] nivelArma;

    public ArmaduraScriptable[] armaduras;
    public Text[] nombreArmadura;
    public Text[] descripcionArmadura;
    public Image[] imagenArmadura;
    public Text[] defensaArmadura;
    public Text[] nivelArmadura;


    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            
        }else
        {
            Destroy(this);
        }
    }


    public void AddArma(ArmasScriptable arma) {
        {
            for(int i = 0; i < armas.Length; i++)
            {
                if(armas[i] == null)
                {
                    armas[i] = arma;
                    nombreArma[i].text = arma.weaponName;
                    descripcionArma[i].text = arma.weaponDescription;
                    imagenArma[i].sprite = arma.weaponImage;
                    nivelArma[i].text = arma.weaponLevel.ToString();
                    DpsArma[i].text = arma.weaponAttack.ToString();
                    return;
                }
            }
        }
    }


    public void AddArmadura(ArmaduraScriptable armadura) {
        {
            for(int i = 0; i < armaduras.Length; i++)
            {
                if(armaduras[i] == null)
                {
                    armaduras[i] = armadura;
                    nombreArmadura[i].text = armadura.armorName;
                    descripcionArmadura[i].text = armadura.armorDescription;
                    imagenArmadura[i].sprite = armadura.armorImage;
                    nivelArmadura[i].text = armadura.armorLevel.ToString();
                    defensaArmadura[i].text = armadura.armorDefense.ToString();
                    return;
                }
            }
        }
    }



    
}
