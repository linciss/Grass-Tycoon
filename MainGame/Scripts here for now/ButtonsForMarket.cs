using Godot;
using System;

public class ButtonsForMarket : Control
{
    General general;
    Money money;
    [Export] NodePath[] buttPath;
    [Export] NodePath[] labelPath;
    public int valueLevel = 0, growthLevel = 0, yieldLevel = 0, countLevel = 0;
    float grassValuePrice = 10, grassGrowthPrice = 20, grassYieldPrice = 50, grassCountPrice = 5000;
    Button value, growth, yield, count;
    Label valueL, growthL, yieldL, countL; 
    
    private PackedScene grass;

    public override void _Ready()
    {
        general = GetNode<General>("/root/Node2D/Grass");
        money = GetNode<Money>("/root/Money");
        value = GetNode < Button>(buttPath[0]);
        growth = GetNode<Button>(buttPath[1]);
        yield = GetNode<Button>(buttPath[2]);
        count = GetNode<Button>(buttPath[3]);
        valueL = GetNode<Label>(labelPath[0]);
        growthL = GetNode<Label>(labelPath[1]);
        yieldL = GetNode<Label>(labelPath[2]);
        countL = GetNode<Label>(labelPath[3]);
        grass = (PackedScene)ResourceLoader.Load("res://MainGame/Grass/Grass.tscn");

    }

    public void _on_Value_pressed()
    {
        if (money.money < grassValuePrice)
        {
            GD.Print("Not enough money");
            return;

        }
            valueLevel++;
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
        growthLevel++;
        money.money -= grassGrowthPrice;
        money.growthTime -= 0.01f;
        grassGrowthPrice *= 2f;
        growth.Text = "Buy " + System.Math.Round(grassGrowthPrice, 2) + " $";
        
    }


    public void _on_Yield_pressed()
    {
        if (money.money < grassYieldPrice)
        {
            GD.Print("Not enough money");
            return;

        }
        yieldLevel++;   
        money.money -= grassYieldPrice;
        money.grassYield++;
        grassYieldPrice *= 3.5f;
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

        countLevel++;
        money.boughtGrass++;
        money.money -= grassCountPrice;
        grassCountPrice *= 7f;
        Node2D grass = (Node2D)this.grass.Instance();
        grass.Position = new Vector2((money.boughtGrass * 50) + grass.Position.x, 304);
        AddChild(grass);
        count.Text = "Buy " + System.Math.Round(grassCountPrice, 2) + " $";
    }

    public override void _PhysicsProcess(float delta)
    {
     
        valueL.Text = "Level: " + valueLevel;
        growthL.Text = "Level: " + growthLevel;
        yieldL.Text = "Level: " + yieldLevel;
        countL.Text = "Level: " + countLevel;


    }
}
