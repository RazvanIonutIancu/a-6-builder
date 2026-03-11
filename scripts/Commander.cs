using Godot;
using System;
using System.Collections;
using System.Collections.Generic;

public partial class Commander : Node
{

    Stack<Area3D> undoStack = new Stack<Area3D>();
    Stack<Area3D> redoStack = new Stack<Area3D>();








    public override void _Process(double delta)
    {

        if (Input.IsActionJustPressed("Undo") && undoStack.Count > 0)
        {
            redoStack.Push(undoStack.Peek());
            Switch(undoStack.Pop());
        }


        if (Input.IsActionJustPressed("Redo") && redoStack.Count > 0)
        {
            undoStack.Push(redoStack.Peek());
            Switch(redoStack.Pop());
        }

    }










    public void ShowTile(Area3D tile)
    {
        if (tile.GetChild<MeshInstance3D>(0).Visible == false)
        {
            tile.GetChild<MeshInstance3D>(0).Visible = true;
            undoStack.Push(tile);
            redoStack.Clear();
        }
    }


    public void HideTile(Area3D tile)
    {
        if (tile.GetChild<MeshInstance3D>(0).Visible == true)
        {
            tile.GetChild<MeshInstance3D>(0).Visible = false;
            undoStack.Push(tile);
            redoStack.Clear();
        }
    }


    public void Switch(Area3D tile)
    {

        if (tile.GetChild<MeshInstance3D>(0).Visible == false)
        {
            tile.GetChild<MeshInstance3D>(0).Visible = true;
        }
        else
        {
            tile.GetChild<MeshInstance3D>(0).Visible = false;
        }
    }




}
