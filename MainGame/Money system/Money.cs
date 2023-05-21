using Godot;
using System;

public class Money : Node
{
    public float grassPrice = 1f, grassYield = 1f, money = 0, growthTime = 1;
    public int boughtGrass = 0;


    public void cutGrass(int bladesCut)
    {
        money += grassPrice * grassYield * bladesCut;
    }

    public override void _Process(float delta)
    {
        




    }
}
