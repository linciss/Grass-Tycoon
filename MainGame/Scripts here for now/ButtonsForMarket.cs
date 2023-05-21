using Godot;
using System;

public class ButtonsForMarket : Control
{
    General general;
    Money money;
    float grassValuePrice = 10, grassGrowthPrice = 15, grassYieldPrice = 100, grassCountPrice = 1000;


    public override void _Ready()
    {
        general = GetNode<General>("/root/Node2D/Grass");
        money = GetNode<Money>("/root/Money");

    }

    public void _on_Value_pressed()
    {
        if (money.money < grassValuePrice)
        {
            GD.Print("Not enough money");
            return;

        }
            GD.Print("Value");
            money.money -= grassValuePrice;
            money.grassPrice += 0.5f;
            grassValuePrice *= 1.5f;

    }



/*    public void _on_Growth_pressed()
    {
        if (general.money >= grassGrowthPrice)
        {
            general.money -= grassGrowthPrice;
            general.time -= 0.1f;
            grassGrowthPrice *= 1.5f;
        }
    }*/





}
