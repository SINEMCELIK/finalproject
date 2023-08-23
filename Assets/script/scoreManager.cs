using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour
{
    
    public Text durum,scoretext;
    public int score = 0;
    public Button btn,exitbtn,menubtn;
    // Start is called before the first frame update
    void Start()
    {
        GuncelleSkor();
    }



    public void Artýs(int miktar)
    {
        score += miktar;
        GuncelleSkor();
    }

    public void GuncelleSkor()
    {
        scoretext.text = "score:" + score;
    }
    // Update is called once per frame
    void Update()
    {
        //print(score);
        if (score == 10)
        {
            Kazandiniz();
        }
    }
    private void Kazandiniz()
    {
        durum.text = "KAZANDIN";
        SceneManager.LoadScene(3);
        //print("Kazandýnýz! Kazanma iþlemleri burada yapýlabilir.");
    }
}
