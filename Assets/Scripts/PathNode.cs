using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathNode : MonoBehaviour
{
    private Grid<PathNode> grid;
    private int x;
    private int y;

    public int gCost;
    public int hCost;
    public int fCost;

    public PathNode cameFromNode;
   /* public PathNode(Grid<pathNode> l_grid, int l_x, int l_y)
    {
        grid = l_grid;
        x = l_x;
        y = l_y;        
    }
    public override string ToString()
    {
        return x + "," + y ;
    }
   */
}
   