using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTilePrefab;

    Vector3 nextspawnpoint;




    public void spawnTile()
    {
        GameObject tempGround = Instantiate(groundTilePrefab, nextspawnpoint, Quaternion.identity);
        nextspawnpoint = tempGround.transform.GetChild(1).transform.position;
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            spawnTile();
        }
    }


}
