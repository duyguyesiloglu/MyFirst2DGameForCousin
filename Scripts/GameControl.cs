using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    GameObject boraPrefab;

    [SerializeField]
    List<GameObject> dolaraltinPrefabs = new List<GameObject>();

    GameObject Bora;


    [SerializeField]
    int zorluk = 1;

    [SerializeField]
    int carpan = 5;

    UIControl uikontrol;

    List<GameObject> dolarList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        uikontrol = GetComponent<UIControl>();
    }
    public void oyunubaslat()
    {
        uikontrol.gameStart();

        Bora = Instantiate(boraPrefab);
        Bora.transform.position = new Vector3(0, EkranHesaplayicisii.Alt - 5.5f);
        DolarAltinUret(5);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void DolarAltinUret(int adet)
    {
        Vector3 position = new Vector3();

        for (int i = 0; i < adet; i++)
        {
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            position.x = Random.Range(EkranHesaplayicisi.Sol, EkranHesaplayicisi.Sag);
            position.y = EkranHesaplayicisi.Ust - 1;

            GameObject dolar = Instantiate(dolaraltinPrefabs[Random.Range(0, 4)], position, Quaternion.identity);
            dolarList.Add(dolar);
        }
    }
    public void ObjectYokOldu(GameObject dolar)
    {
        uikontrol.ObjectYokOldu(dolar);

        dolarList.Remove(dolar);
        
        if (dolarList.Count <= zorluk)
        {
            zorluk++;
            DolarAltinUret(zorluk * carpan);
        }

    }
    public void GameOver()
    {
        foreach (GameObject obje in dolarList)
        {
            obje.GetComponent<Objeler>().Yoket();
        }
        dolarList.Clear();
        zorluk = 1;
        uikontrol.gameover();
    }
}