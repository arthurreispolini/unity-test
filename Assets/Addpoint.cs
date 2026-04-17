using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addpoint : MonoBehaviour
{
public LixoSpawnerController lixoSpawnerController;

private void OnCollisionEnter(Coliision coliision)
    {
        if (coliision.gameObject.CompareTag("Lixo"))
        {
            Destroy(coliision.gameObject);
            lixoSpawnerController.Addpoint(1);
        }
    }
}
