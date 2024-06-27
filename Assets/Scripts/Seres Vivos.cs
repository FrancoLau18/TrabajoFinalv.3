using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeresVivos : MonoBehaviour
{
    public float Life;
    public float Attack;
    protected void Verificate_Life()
    {
        if (Life <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
