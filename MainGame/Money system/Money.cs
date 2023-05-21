using Godot;
using System;

public class Money : Node
{
    public double money = 0;
    public float grassPrice = 1f, grassYield = 1f;


    public void cutGrass(int bladesCut)
    {
        money += grassPrice * grassYield * bladesCut;
    }

    public override void _Process(float delta)
    {
        




    }
}
