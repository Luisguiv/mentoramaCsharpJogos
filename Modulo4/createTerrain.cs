using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createTerrain : MonoBehaviour
{
    [SerializeField] GameObject cube;
    static int terrainSize = 12;
    private int randomHeight;
    int[,] heightMatrix = new int[terrainSize, terrainSize];

    void Start()
    {
        fillBorder();
        fillInnerBorder();

        for (int i = 2; i < terrainSize - 2; i++)
        {
            for (int j = 2; j < terrainSize - 2; j++)
            {
                randomHeight = Random.Range(1, 5);
                for (int k = 0; k < randomHeight; k++)
                {
                    Instantiate(cube, new Vector3(i, k, j), Quaternion.identity);
                }
            }
        }
    }
    
    void fillInnerBorder()
    {
        int i, j;

        i = 1;
        for (j = 1; j < terrainSize - 1; j++) // if i=1
        {
            while((randomHeight = Random.Range(1, 6)) > heightMatrix[0,j]);
            for (int k = 0; k < randomHeight; k++)
            {
                Instantiate(cube, new Vector3(i, k, j), Quaternion.identity);
            }
        }
        i = terrainSize-2;
        for (j = 1; j < terrainSize - 1; j++) // if i=terrainSize-1
        {
            while((randomHeight = Random.Range(1, 6)) > heightMatrix[terrainSize-1,j]);
            for (int k = 0; k < randomHeight; k++)
            {
                Instantiate(cube, new Vector3(i, k, j), Quaternion.identity);
            }
        }
        
        j = 1;
        for (i = 2; i < terrainSize-2; i++) // if j==1
        {
            while((randomHeight = Random.Range(1, 6)) > heightMatrix[i,0]);
            for (int k = 0; k < randomHeight; k++)
            {
                Instantiate(cube, new Vector3(i, k, j), Quaternion.identity);
            }
        }
        
        j = terrainSize-2;
        for (i = 2; i < terrainSize-2; i++) // if j==terrainSize-1
        {
            while((randomHeight = Random.Range(1, 6)) > heightMatrix[i,terrainSize-1]);
            for (int k = 0; k < randomHeight; k++)
            {
                Instantiate(cube, new Vector3(i, k, j), Quaternion.identity);
            }
        }
    }
    
    void fillBorder()
    {
        int i, j;

        i = 0;
        for (j = 0; j < terrainSize; j++) // if i==0
        {
            randomHeight = Random.Range(1, 7);
            heightMatrix[i, j] = randomHeight;
            for (int k = 0; k < randomHeight; k++)
            {
                Instantiate(cube, new Vector3(i, k, j), Quaternion.identity);
            }
        }

        i = terrainSize-1;
        for (j = 0; j < terrainSize; j++) // if i==terrainSize
        {
            randomHeight = Random.Range(1, 7);
            heightMatrix[i, j] = randomHeight;
            for (int k = 0; k < randomHeight; k++)
            {
                Instantiate(cube, new Vector3(i, k, j), Quaternion.identity);
            }
        }

        j = 0;
        for (i = 1; i < terrainSize-1; i++) // if j==0
        {
            randomHeight = Random.Range(1, 7);
            heightMatrix[i, j] = randomHeight;
            for (int k = 0; k < randomHeight; k++)
            {
                Instantiate(cube, new Vector3(i, k, j), Quaternion.identity);
            }
        }

        j = terrainSize-1;
        for (i = 1; i < terrainSize-1; i++) // if j==terrainSize
        {
            randomHeight = Random.Range(1, 7);
            heightMatrix[i, j] = randomHeight;
            for (int k = 0; k < randomHeight; k++)
            {
                Instantiate(cube, new Vector3(i, k, j), Quaternion.identity);
            }
        }
    }
}