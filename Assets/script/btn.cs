using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn : MonoBehaviour
{
    public void YenidenBasla()
    {
        SceneManager.LoadScene(1);
    }
}
