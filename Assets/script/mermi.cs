using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class mermi : MonoBehaviour
{
    public GameObject mermiPrefab; // Mermi prefab�
    public Transform atisNoktasi; // Mermi at�� noktas�
    public float atisHizi = 50.0f; // Mermi at�� h�z�

    public void AtesButtonTiklandi()
    {
        AtesEt();
    }

    void AtesEt()
    {
        // Mermiyi at�� noktas�nda olu�tur
        GameObject yeniMermi = Instantiate(mermiPrefab, atisNoktasi.position, atisNoktasi.rotation);

        // Mermiye h�z vererek ate�le
        Rigidbody mermiRigidbody = yeniMermi.GetComponent<Rigidbody>();
        mermiRigidbody.velocity = atisNoktasi.forward * atisHizi;
    }
}
