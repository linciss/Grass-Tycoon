using Godot;
using System;

public class SpawnGrass : Node2D
{


    private PackedScene grass;

    public override void _Ready()
    {
        grass = (PackedScene)ResourceLoader.Load("res://MainGame/Grass/Grass.tscn");


    }
    public void _on_Button_pressed()
    {
        Node2D grass = (Node2D)this.grass.Instance();
        grass.Position = new Vector2(450, 304);
        AddChild(grass);
        GD.Print("sadasdsad");
    }




}
