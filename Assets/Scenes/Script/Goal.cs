using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Material hitMaterial;
    public GameLogic gameLogic;
    private void OnTriggerEnter(Collider other)
    {
       GetComponent<MeshRenderer>().material = hitMaterial;
       gameLogic.goals += 1;
       Destroy(this);
    }
}
