using Godot;
using System;

public class Button : Godot.Button
{

    PackedScene grass;

    public override void _Ready()
    {
        grass = (PackedScene)ResourceLoader.Load("res://TEST.tscn");
    }

    public void _on_Button_pressed()
    {
        Node2D grass = (Node2D)this.grass.Instance();

        grass.Position = new Vector2(50, 50);

        AddChild(grass);

        GD.Print("sadasdsad");
    }


    }
