using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    List<Card> holster;
    public Hand hand;


    public void Draw()
    {
        hand.hand.Add(holster[0]);
        holster.RemoveAt(0);
    }

}
