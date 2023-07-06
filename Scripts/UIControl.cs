using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    [SerializeField]
    GameObject GameNameText = default;
    [SerializeField]
    GameObject GameEnd = default;
    [SerializeField]
    Text PuanText = default;
    [SerializeField]
    GameObject PlayButton = default;

    [SerializeField]
    GameObject winGame = default;

    int puan;


    // Start is called before the first frame update
    void Start()
    {
        GameEnd.gameObject.SetActive(false);
        PuanText.gameObject.SetActive(false);
    }
    public void gameStart()
    {
        puan = 0;
        GameNameText.gameObject.SetActive(false);
        PlayButton.gameObject.SetActive(false);
        PuanText.gameObject.SetActive(true);
        GameEnd.gameObject.SetActive(false);
        PuanGuncelle();

       


    }
    public void gameover()
    {
        GameEnd.gameObject.SetActive(true);
        PlayButton.gameObject.SetActive(true);
    }
    // Update is called once
    // per frame

    void PuanGuncelle()
    {
        PuanText.text = "SCORE: " + puan; ;
    }
    public void ObjectYokOldu(GameObject obje)
    {
        switch (obje.gameObject.name[2])
        {
            case 'l':
                puan += 100;
                PuanGuncelle();
                break;
            case 'g':
                puan += 200;
                PuanGuncelle();
                break;
            case 'u':
                puan += 50;
                PuanGuncelle();
                break;
            case 'm':
                puan -= 25;
                PuanGuncelle();
                break;
            default:
                break;
        }
    }
}
