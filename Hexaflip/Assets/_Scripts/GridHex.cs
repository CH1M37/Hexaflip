using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridHex : MonoBehaviour {
    [SerializeField]
    GameObject tilePrefab;
    [Tooltip("Number of tiles on one single Line. Total number will be numberOfTiles * numberOfTiles")]
    public int numberOfTiles;

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
        //Get Mesh Size
        GameObject firstTile = Instantiate(tilePrefab);
        GameObject hexa = firstTile.transform.GetChild(0).gameObject;
        MeshCollider mesh = hexa.GetComponent<MeshCollider>();
        Bounds bounds = mesh.bounds;

        float zDelta = bounds.size.z;
        float xDelta = zDelta * Mathf.Sqrt(3) / 2f;

        //Destroy firstTile to avoid issues with the tile at index (0,0)
        DestroyImmediate(firstTile);

        //Spawn Tiles
        for (int i=0; i<n;i++)
        {
            //even lines
            if (i % 2 == 0)
            { 
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
                for (int j = 0; j < n; j++)
                {
                    GameObject tile = Instantiate(tilePrefab);
                    tile.transform.SetParent(this.transform, false);
                    tile.transform.position = Vector3.zero;
                    tile.transform.position = new Vector3(xDelta * i, 0f, zDelta * j) + new Vector3(0f, 0f, zDelta / 2f);
                }
            }
        }
    }
    #endregion
}
