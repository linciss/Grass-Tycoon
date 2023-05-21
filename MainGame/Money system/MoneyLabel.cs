using Godot;
using System;

public class MoneyLabel : Label
{
    float money;

    public override void _Ready()
    {
       
    }
    public override void _PhysicsProcess(float delta)
    {
        Text = "Money: " + System.Math.Round(((Money)GetNode("/root/Money")).money, 2);     
    }
}
