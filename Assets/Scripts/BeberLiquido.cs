using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeberLiquido : MonoBehaviour
{
    public void Beber()
    {
        GameManager.instance.bebeuLiquido = true;
    }
}
