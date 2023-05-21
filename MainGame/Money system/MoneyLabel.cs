using Godot;
using System;

public class MoneyLabel : Label
{
    public override void _PhysicsProcess(float delta)
    {
        Text = "Money: " + ((Money)GetNode("/root/Money")).money;
    }
}
