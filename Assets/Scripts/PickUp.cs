using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public static int contador = 0;

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            contador++;

            Debug.Log("Objetos recolectados: " + contador);

            Destroy(gameObject);
        }
    }
}
