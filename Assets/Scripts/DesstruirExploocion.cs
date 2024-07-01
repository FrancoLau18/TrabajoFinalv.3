using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesstruirExploocion : MonoBehaviour
{
    void Update()
    {
        Destroy(this.gameObject, 0.6f);
    }
}
