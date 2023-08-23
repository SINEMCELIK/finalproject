using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class askerkontrol : MonoBehaviour
{
    public float maxHiz = 5.0f;
    private Vector3 hedefNokta;
    private System.Random random;

    private void Start()
    {
        random = new System.Random();
        YeniHedefBelirle();
    }

    private void Update()
    {
        // Hedefe doðru ilerle
        Vector3 hareketYonu = (hedefNokta - transform.position).normalized;
        transform.position += hareketYonu * maxHiz * Time.deltaTime;

        // Eðer hedefe yakýnsa yeni hedef belirle
        if (Vector3.Distance(transform.position, hedefNokta) < 0.5f)
        {
            YeniHedefBelirle();
        }

        // Yönü hedefe doðru ayarla
        transform.LookAt(hedefNokta);
    }

    private void YeniHedefBelirle()
    {
        // Rastgele bir hedef noktasý belirle
        float x = random.Next(-20, 21); // X koordinatý -50 ile 50 arasýnda rastgele bir deðer alýr
        float z = random.Next(-20, 21); // Z koordinatý -50 ile 50 arasýnda rastgele bir deðer alýr
        hedefNokta = new Vector3(x, 0f, z); // Y koordinatý 0 olarak ayarlanýr
    }
}
