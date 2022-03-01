using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridHolder : MonoBehaviour
{
    [SerializeField] private int _rows;
    [SerializeField] private int _columns;
    [SerializeField] private int _areaOfInterest;
/*    [SerializeField] private Tile _tilePrefab*/

    private void Start()
    {
        generateGrid();
    }

    private void generateGrid()
    {
        transform.position = new Vector2(0, 0);
        GameObject refTile = (GameObject)Instantiate(Resources.Load("Tile"));
        for (int row = 0;  row < _rows; ++row)
        {
            for (int col = 0; col < _columns; ++col)
            {
                GameObject tile = (GameObject)Instantiate(refTile, transform);
                float posX = col * _areaOfInterest;
                float posY = row * _areaOfInterest;

                tile.transform.position = new Vector2(posX, posY);
            }
        }
        Destroy(refTile);
        float gridW = _columns * _areaOfInterest;
        float gridH = _rows * _areaOfInterest;
        transform.position = new Vector2(-gridW / 2 + _areaOfInterest / 2, gridH / 2 - _areaOfInterest / 2);
    }
}
