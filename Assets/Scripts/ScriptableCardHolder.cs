using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptableCardHolder : MonoBehaviour
{
    public TextMeshProUGUI cardName;
    public TextMeshProUGUI cardDescription;
    public TextMeshProUGUI bulletCost;
    public Card card;
    // Start is called before the first frame update
    void Start()
    {
        if (card != null)
        {
            cardName.text = card.cardName;
            cardDescription.text = card.description;
            bulletCost.text = "BC: " + card.bulletCost;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
