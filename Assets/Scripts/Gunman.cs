using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card/Gunmen")]
public class Gunman : Card
{
    public int max_grit;
    public int grit;
    public int base_firepower;
    public int firepower;
    public int base_attacks;
    public int attacks;
    

    public List<Equipment> equipment;
}
