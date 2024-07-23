using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(FileName = "NewCard", menuName = "Card/typeless")]
public class Card : ScriptableObject
{
    public int bulletCost;
    public string cardName;
    public string description;
    public string cardType;
}
