using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        this.gameObject.SetActive(false);
    }
}
