using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    private float cellSize;
    private int width;
    private int height;
    private int[,] gridArray;
    private Vector3 originPosition;

    public Grid(int l_width, int l_height, float l_cellSize, Vector3 originPosition)
    {
        this.width = l_width;
        this.height = l_height;
        this.cellSize = l_cellSize;
        this.originPosition = originPosition;
        gridArray = new int[width, height];

        for(int x=0; x<gridArray.GetLength(0);x++)
        {
            for (int y = 0; y< gridArray.GetLength(1); y++)
            {
                Debug.DrawLine(GetWolrldPosition(x, y), GetWolrldPosition(x, y + 1),Color.white);
                Debug.DrawLine(GetWolrldPosition(x, y), GetWolrldPosition(x+1, y ),Color.white);
            }
        }
        Debug.DrawLine(GetWolrldPosition(0, height), GetWolrldPosition(width, height), Color.white);
        Debug.DrawLine(GetWolrldPosition(width, 0), GetWolrldPosition(width, height), Color.white);
    }
    private Vector3 GetWolrldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize + originPosition;
    }
    private void GetXY(Vector3  worldPosition, out int x, out int y)
    {
        x = Mathf.FloorToInt((worldPosition - originPosition).x / cellSize);
        y = Mathf.FloorToInt((worldPosition - originPosition).y / cellSize);
    }
    public void SetValue(int x, int y, int value)
    {
        if(x>=0 && y >=0 && x<width && y< height)
        gridArray[x, y] = value;
    }
    public void SetValue (Vector3 worldPosition, int value)
    {
        int x, y;
        GetXY(worldPosition, out x, out y);
        SetValue(x, y, value);
    }
    public int GetValue(int x, int y)
    {
        if (x >= 0 && y >= 0 && x < width && y < height)
            return gridArray[x, y];
        return -1;
    }
    public int GetValue(Vector3 worldPosition)
    {
        int x, y;
        GetXY(worldPosition, out x, out y);
        return GetValue(x, y);
    }
}
