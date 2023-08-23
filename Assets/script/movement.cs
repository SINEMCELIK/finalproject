using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class movement : MonoBehaviour
{
    
    public Text zaman, can,durum;
    public Slider canSlider;
    float canSayisi = 20;
    float zamanSayaci = 50;
    public float hareketHizi = 5f;
    public float donusHizi = 60f;
    bool oyunDevam = true;
    bool oyunTamam = false;


    private void Start()
    {
        UpdateCanUI();
    }
    void Update()
    {

        if (oyunDevam && !oyunTamam)
        {
            zamanSayaci -= Time.deltaTime;
            zaman.text = (int)zamanSayaci + "";
        }
        else if (!oyunTamam)
        {
            OyunBitir("Game Over");
        }
        if (zamanSayaci < 0)
        {
            OyunBitir("Time's up");

        }
        
    }
    void FixedUpdate()
    {
        
            float hareketInput = Input.GetAxis("Vertical");
            float donusInput = Input.GetAxis("Horizontal");

            HareketEt(hareketInput);
            DonusYap(donusInput);
        
    }

        void HareketEt(float hareketInput)
    {
        Vector3 hareket = transform.forward * hareketInput * hareketHizi * Time.deltaTime;
        transform.position += hareket;
    }

    void DonusYap(float donusInput)
    {
        float donusMiktari = donusInput * donusHizi * Time.deltaTime;
        Quaternion donusAci = Quaternion.Euler(0f, donusMiktari, 0f);
        transform.rotation *= donusAci;
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("mayýn"))
        {
             print("can azaldý");
            canSayisi -= 1;
            UpdateCanUI();
            if (canSayisi == 0)
            {
                OyunBitir("Game Over You died");

            }     
        }
    }
    void UpdateCanUI()
    {
        canSlider.value = canSayisi;
        can.text = canSayisi.ToString();
    }

    void OyunBitir(string durumMetni)
    {
        oyunDevam = false;
        oyunTamam = true;
        durum.text = durumMetni;
        Thread.Sleep(2000);
        SceneManager.LoadScene(2);
       
    }
}
