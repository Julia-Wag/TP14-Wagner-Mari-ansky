using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleArea : MonoBehaviour
{
   public int score = 0;

    private UIManager uiManager;

    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lapicera"))
        {
            score++;

            uiManager.UpdateScore(score);

            Destroy(other.gameObject);
        }
    }
}
