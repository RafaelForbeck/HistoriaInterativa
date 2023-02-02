using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AtirarGarrafa : MonoBehaviour
{
    public void Atirar()
    {
        if (GameManager.instance.bebeuLiquido)
        {
            SceneManager.LoadScene("Dragao");
        } else
        {
            SceneManager.LoadScene("GuardaAtaca");
        }
    }
}
