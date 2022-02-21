using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchy : MonoBehaviour
{
    public GameObject upper;
    public GameObject lower;
    public GameObject skybox1;
    public GameObject skybox2;


    public void OnTriggerEnter(Collider other)
    {
        upper.SetActive(false);
        lower.SetActive(true);
        skybox1.SetActive(false);
        skybox2.SetActive(true);
        Debug.Log("An object entered.");
    }
}
