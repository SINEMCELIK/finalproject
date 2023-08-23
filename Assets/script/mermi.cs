using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class mermi : MonoBehaviour
{
    public GameObject mermiPrefab; // Mermi prefabý
    public Transform atisNoktasi; // Mermi atýþ noktasý
    public float atisHizi = 50.0f; // Mermi atýþ hýzý

    public void AtesButtonTiklandi()
    {
        AtesEt();
    }

    void AtesEt()
    {
        // Mermiyi atýþ noktasýnda oluþtur
        GameObject yeniMermi = Instantiate(mermiPrefab, atisNoktasi.position, atisNoktasi.rotation);

        // Mermiye hýz vererek ateþle
        Rigidbody mermiRigidbody = yeniMermi.GetComponent<Rigidbody>();
        mermiRigidbody.velocity = atisNoktasi.forward * atisHizi;
    }
}
