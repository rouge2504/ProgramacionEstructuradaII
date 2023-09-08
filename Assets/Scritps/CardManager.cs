using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public RawImage rawImage;
    public string nameData;
    private string rute;
    void Start()
    {
        rute = Application.streamingAssetsPath + "/" + nameData + ".json";
        /*Card card = new Card("Cubone", "Tierra", 10, 20, 15, true, "CuboneTex");

        print(card.name);

        string json = JsonUtility.ToJson(card, true);

        print(json);

        print(Application.streamingAssetsPath);


        System.IO.File.WriteAllText(rute, json);*/

        WriteCardArray();
    }

    public void WriteCardArray()
    {
        Card[] card = new Card[6];

        card[0] = new Card("Cubone", "Tierra", 10, 20, 15, true, "CuboneTex");
        card[1] = new Card("Pigeot", "Aire", 10, 20, 15, true, "CuboneTex");
        card[2] = new Card("Gengar", "Fantasma", 10, 20, 15, true, "CuboneTex");
        card[3] = new Card("Chilaquil", "Fuego", 10, 20, 15, true, "CuboneTex");
        card[4] = new Card("Pikachu", "Electrico", 10, 20, 15, true, "CuboneTex");
        card[5] = new Card("Golem", "Tierra", 10, 20, 15, true, "CuboneTex");

        string json = JsonHelper.ToJson(card, true);

        print(json);

        System.IO.File.WriteAllText(rute, json);
    }

    public void Update()
    {
        ReadCard();
    }

    public void ReadCard()
    {


        string json = System.IO.File.ReadAllText(rute);

        Card card = JsonUtility.FromJson<Card>(json);

        Texture texture = Resources.Load<Texture>(card.nameTexture); //Rescatar imagen de Resources
        rawImage.texture = texture; // Vista de imagen en UI
        print(card.name);
    }

 
}

