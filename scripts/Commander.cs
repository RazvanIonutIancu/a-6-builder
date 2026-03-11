using Godot;
using System;
using System.Collections;

public partial class Commander : Node
{

    Stack undoStack = new Stack();








    public override void _Process(double delta)
    {





    }










    public void ShowTile(Area3D tile)
    {
        if (tile.GetChild<MeshInstance3D>(0).Visible == false)
        {
            tile.GetChild<MeshInstance3D>(0).Visible = true;
        }
    }


    public void HideTile(Area3D tile)
    {
        if (tile.GetChild<MeshInstance3D>(0).Visible == true)
        {
            tile.GetChild<MeshInstance3D>(0).Visible = false;
        }
    }


}
