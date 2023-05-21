using Godot;
using System;

public class TESTINGGGG : Node2D
{


    private PackedScene grass;

    public override void _Ready()
    {
        grass = (PackedScene)ResourceLoader.Load("res://TEST2.tscn");


    }
    public void _on_Button_pressed()
    {
        Node2D grass = (Node2D)this.grass.Instance();
        AddChild(grass);
        GD.Print("sadasdsad");
    }




}
