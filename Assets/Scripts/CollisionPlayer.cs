using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
     public static int contador = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lapicera"))
        {
            contador++;

            Debug.Log("Objetos recolectados: " + contador);

            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
