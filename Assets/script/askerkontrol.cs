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
        // Hedefe do�ru ilerle
        Vector3 hareketYonu = (hedefNokta - transform.position).normalized;
        transform.position += hareketYonu * maxHiz * Time.deltaTime;

        // E�er hedefe yak�nsa yeni hedef belirle
        if (Vector3.Distance(transform.position, hedefNokta) < 0.5f)
        {
            YeniHedefBelirle();
        }

        // Y�n� hedefe do�ru ayarla
        transform.LookAt(hedefNokta);
    }

    private void YeniHedefBelirle()
    {
        // Rastgele bir hedef noktas� belirle
        float x = random.Next(-20, 21); // X koordinat� -50 ile 50 aras�nda rastgele bir de�er al�r
        float z = random.Next(-20, 21); // Z koordinat� -50 ile 50 aras�nda rastgele bir de�er al�r
        hedefNokta = new Vector3(x, 0f, z); // Y koordinat� 0 olarak ayarlan�r
    }
}
