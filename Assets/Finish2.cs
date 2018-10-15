using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish2 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Player").SendMessage("Finish");
    }
}