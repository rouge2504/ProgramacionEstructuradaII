using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card
{
    public string name;
    public string type;
    public int hp;
    public int resistance;
    public string nameTexture;
    public Sprite imageSprite;
    public int attack;
    public bool shiny;

    public Card(string name, string type, int hp, int resistance, int attack, bool shiny, string nameTexture)
    {
        this.name = name;
        this.type = type;
        this.hp = hp;
        this.resistance = resistance;
        this.attack = attack;
        this.shiny = shiny;
        this.nameTexture = nameTexture;
    }
}
