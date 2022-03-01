using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
/*    [SerializeField] private int[,] Grid;*/
    [SerializeField] private int _gridVertical, _gridHorizontal;
    [SerializeField] private GameObject _tilePrefab;

    private void Start()
    {
        generateGrid();
    }

    private void generateGrid()
    {
        for (int i = 0; i < _gridHorizontal; ++i)
        {
            for (int j = 0; j < _gridVertical; ++j)
            {
                GameObject tile = Instantiate(_tilePrefab);
/*                var spawnTile = Instantiate(_tilePrefab, new Vector3(i, j), Quaternion.identity);
                spawnTile.name = "Tile {x} {y}";*/

            }
        }
    }
}
