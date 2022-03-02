using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainRenderDistance : MonoBehaviour
{
    private void Update()
    {
        switch (GameManager.playerRenderDistance)
        {
            case 0 :
            {
                transform.GetComponent<Terrain>().detailObjectDistance = 50f;
                break;
            }
            case 1 :
            {
                transform.GetComponent<Terrain>().detailObjectDistance = 150f;
                break;
            }
            case 2 :
            {
                transform.GetComponent<Terrain>().detailObjectDistance = 250f;
                break;
            }

        }
    }
}
