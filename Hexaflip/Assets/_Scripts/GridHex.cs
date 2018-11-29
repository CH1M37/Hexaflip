using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridHex : MonoBehaviour {

    [SerializeField]
    private GameObject tilePrefab;
    [Tooltip("Number of tiles on one single Line. Total number will be numberOfTiles * numberOfTiles")]
    public int numberOfTiles;
    [HideInInspector]
    public float xDelta = 1.5f;
    [HideInInspector]
    public float zDelta = 1.7f;

    #region Grid Creation

    public void ResetGrid()
    {
        GameObject[] tilesArray = GameObject.FindGameObjectsWithTag("tile");

        foreach (GameObject tileToDestroy in tilesArray)
        {
            DestroyImmediate(tileToDestroy);
        }

    }

    public void CreateGrid(int n)
    {
        for(int i=0; i<n;i++)
        {
            //even lines
            if (i % 2 == 0)
            { 
                Debug.Log("i pair " + i);
                for (int j = 0; j < n; j++)
                {
                    GameObject tile = Instantiate(tilePrefab);
                    tile.transform.SetParent(this.transform, false);
                    tile.transform.position = Vector3.zero;
                    tile.transform.position = new Vector3(xDelta * i, 0f, zDelta * j);
                }
            }
            //odd lines
            else
            {
                Debug.Log("i impair " + i);
                for (int j = 0; j < n; j++)
                {
                    GameObject tile = Instantiate(tilePrefab);
                    tile.transform.SetParent(this.transform, false);
                    tile.transform.position = Vector3.zero;
                    tile.transform.position = new Vector3(xDelta * i, 0f, zDelta * j + 0.8f);
                }
            }
        }
    }
    #endregion
}
