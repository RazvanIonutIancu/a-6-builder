using Godot;
using System;

public partial class Cube : Area3D
{

    private Commander commander;


    public override void _Ready()
    {
        commander = GetNode<Commander>("/root/TileClicker/Commander");
    }











    private void OnMouseClick(Node camera, InputEvent newEvent, Vector3 event_position, Vector3 normal, int shape_idx)
    {
        if (newEvent is InputEventMouseButton mouseEvent)
        {
            if (mouseEvent.ButtonIndex == MouseButton.Left && mouseEvent.Pressed)
            {
                commander.ShowTile(this);
            }
            else if (mouseEvent.ButtonIndex == MouseButton.Right && mouseEvent.Pressed)
            {
                commander.HideTile(this);
            }

        }

    }
}
