using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeler : MonoBehaviour
{
    [SerializeField]
    GameObject patlamaPrefab = default;

    GameControl gamecontrol;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        gamecontrol = Camera.main.GetComponent<GameControl>();

        float yon = Random.Range(0f, 1.0f);
        if (yon < 0.5)
        {
            rb2d.AddForce(new Vector2(Random.Range(-2.5f, -1.0f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
            rb2d.AddTorque(yon * 2.0f);
        }
        else
        {
            rb2d.AddForce(new Vector2(Random.Range(1.0f, 2.5f), Random.Range(-2.5f, -1.0f)), ForceMode2D.Impulse);
            rb2d.AddTorque(-yon * 2.0f);
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "DudakKursun")

        {
           
               
                GameObject.FindGameObjectWithTag("Audio")
                      .GetComponent<SesKontrol>()
                      .Gold();
                  
                

            


            gamecontrol.ObjectYokOldu(gameObject);
            Yoket();
            
        }
    }
    public void Yoket()
    {
        Instantiate(patlamaPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
