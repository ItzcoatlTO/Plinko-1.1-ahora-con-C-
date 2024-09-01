using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameObject victoryCanvas;
    public GameObject ball;
    public int goals;
    

    // Update is called once per frame
    void Update()
    {
        if (goals >= 5)
        {
            victoryCanvas.SetActive(true);
            Destroy(ball);
            Destroy(this);
        }
    }
}
