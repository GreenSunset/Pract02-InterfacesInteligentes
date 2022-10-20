using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObjects : MonoBehaviour
{
    public GameObject[] Prefabs;
    public Vector3 gridCenter = new Vector3(0, 1, 0);
    public int rows = 10;
    public int columns = 10;
    public float spacing = 3f;

    // Start is called before the first frame update
    void Start()
    {
        // Generate cilinders in a grid with center in the origin (0, 0)
        int negativeRows =  rows/2 - (int) gridCenter.x;
        int negativeColumns = columns/2 - (int) gridCenter.z;
        int positiveRows = rows/2 + (int) gridCenter.x;
        int positiveColumns = columns/2 + (int) gridCenter.z;
        bool oddRows = rows % 2 == 1;
        bool oddColumns = columns % 2 == 1;
        for (int i = -negativeRows; i <= positiveRows; i++)
        {
            for (int j = -negativeColumns; j <= positiveColumns; j++)
            {
                if (oddRows && i == 0 || oddColumns && j == 0)
                {
                    continue;
                }
                Vector3 position = new Vector3(i * spacing, gridCenter.y, j * spacing);
                GameObject cylinder = Instantiate(Prefabs[Random.Range(0, Prefabs.Length)], position, Quaternion.identity);
                cylinder.transform.parent = transform;
            }
        }

    }
}
