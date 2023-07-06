using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    [SerializeField]
    AudioClip gold = default;

    [SerializeField]
    AudioClip Cbum = default;

    [SerializeField]
    AudioClip Bora = default;

    [SerializeField]
    AudioClip dolar = default;

    [SerializeField]
    AudioClip atis = default;

    [SerializeField]
    AudioClip bomba = default;

    AudioSource auidosource;

    // Start is called before the first frame update
    void Start()
    {
        auidosource = GetComponent<AudioSource>();
    }


    public void Gold()
    {
        auidosource.PlayOneShot(gold);
    }


    public void DolarPat()
    {
        auidosource.PlayOneShot(dolar);

    }

    public void CbumPat()
    {
        auidosource.PlayOneShot(Cbum);
    }


    public void Bomb()
    {
        auidosource.PlayOneShot(bomba);
    }

    public void BoraPatlama()
    {
        auidosource.PlayOneShot(Bora);
    }

    public void Ates()
    {
        auidosource.PlayOneShot(atis);
    }

}

