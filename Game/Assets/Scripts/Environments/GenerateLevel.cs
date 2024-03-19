using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos=60;//length of a section
    public bool creatingSection =false;
    public int secNum;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        if (creatingSection==false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());//courite is a method with time delay
        }       
    }

    IEnumerator GenerateSection()
    {
        secNum=Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0,0,zPos), Quaternion.identity);
        zPos += 60;
        yield return new WaitForSeconds(5);
        creatingSection=false;
    }
}
