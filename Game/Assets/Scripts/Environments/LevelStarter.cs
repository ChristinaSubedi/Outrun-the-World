using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countdown3;
    public GameObject countdown2;
    public GameObject countdown1;
    public GameObject countDownGo;
    public GameObject fadeIn;
    public AudioSource readyFX;
    public AudioSource goFX;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(1);
        readyFX.Play();
        countdown3.SetActive(true);
        yield return new WaitForSeconds(1);
        readyFX.Play();
        countdown2.SetActive(true);
        yield return new WaitForSeconds(1);
        readyFX.Play(); 
        countdown1.SetActive(true);
        yield return new WaitForSeconds(1);
        goFX.Play();
        countDownGo.SetActive(true);
        yield return new WaitForSeconds(1);

        PlayerMove.canMove = true;
    }
}
