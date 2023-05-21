using Godot;
using System;

public class ButtonsForMarket : Control
{
    General general;
    Money money;
    float grassValuePrice = 10, grassGrowthPrice = 15, grassYieldPrice = 100, grassCountPrice = 1000;
    Button value, growth, yield, count;
    private PackedScene grass;

    public override void _Ready()
    {
        general = GetNode<General>("/root/Node2D/Grass");
        money = GetNode<Money>("/root/Money");
        value = GetNode<Button>("/root/Node2D/Market/ColorRect/Price/Value");
        growth = GetNode<Button>("/root/Node2D/Market/ColorRect/GrowthRate/GrowthRate");
        yield = GetNode<Button>("/root/Node2D/Market/ColorRect/Yield/Yield");
        count = GetNode<Button>("/root/Node2D/Market/ColorRect/Grass count/Count");
        grass = (PackedScene)ResourceLoader.Load("res://MainGame/Grass/Grass.tscn");

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
            value.Text = "Buy " + System.Math.Round(grassValuePrice, 2) + " $";
    }



    public void _on_Growth_pressed()
    {
        if (money.money < grassGrowthPrice)
        {
            GD.Print("Not enough money");
            return;

        }

        money.money -= grassGrowthPrice;
        money.growthTime -= 0.01f;
        grassGrowthPrice *= 1.5f;
        growth.Text = "Buy " + System.Math.Round(grassGrowthPrice, 2) + " $";
        
    }


    public void _on_Yield_pressed()
    {
        if (money.money < grassYieldPrice)
        {
            GD.Print("Not enough money");
            return;

        }

        money.money -= grassYieldPrice;
        money.grassYield++;
        grassYieldPrice *= 1.5f;
        yield.Text = "Buy " + System.Math.Round(grassYieldPrice, 2) + " $";
        
    }

    public void _on_Count_pressed()
    {

        if (money.money < grassCountPrice)
        {
            GD.Print("Not enough money");
            return;

        }

        if (money.boughtGrass >= 10)
            return;

        money.boughtGrass++;
        money.money -= grassCountPrice;
        grassCountPrice *= 2f;
        Node2D grass = (Node2D)this.grass.Instance();
        grass.Position = new Vector2((money.boughtGrass * 50) + grass.Position.x, 304);
        AddChild(grass);

    }

    public override void _PhysicsProcess(float delta)
    {
        
    }
}
