using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class LevalGenarator : MonoBehaviour
{
    public GameObject groundPrefab;

    public int numberOfGrounds = 200;
    public float levalWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfGrounds; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levalWidth, levalWidth);
            Instantiate(groundPrefab, spawnPosition, quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
