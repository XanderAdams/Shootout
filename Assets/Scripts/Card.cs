using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card/Typeless")]
public class Card : ScriptableObject
{
    public int bulletCost;
    public string cardName;
    public string description;
    public string cardType;
}
