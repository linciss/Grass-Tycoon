using Godot;
using System;

public class SpawnGrass : Node2D
{

    Money money;
    private PackedScene grass;

    public override void _Ready()
    {
        grass = (PackedScene)ResourceLoader.Load("res://MainGame/Grass/Grass.tscn");
        money = (Money)GetNode("/root/Money");

    }
    public void _on_Button_pressed()
    {
        money.boughtGrass++;
        Node2D grass = (Node2D)this.grass.Instance();
        grass.Position = new Vector2((money.boughtGrass * 50) + grass.Position.x, 304);
        AddChild(grass);

    }




}
