using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ateşetme : MonoBehaviour
{
    public int skorArtisMiktari = 1;
    private scoreManager skorKontrol;

    private void Start()
    {
        // SkorKontrol scriptini bul ve bağla
        skorKontrol = FindObjectOfType<scoreManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("mermi"))
        {
            Destroy(gameObject); // Düşmanı yok et
            skorKontrol.Artıs(skorArtisMiktari); // Skoru artır
        }
    }
}



