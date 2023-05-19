using Godot;
using System;

public class ButtonsForMarket : Control
{
    General general = new General();
    Money money = new Money();
    float grassValuePrice = 10, grassGrowthPrice = 15, grassYieldPrice = 100, grassCountPrice = 1000;


    public override void _Ready()
    {
        
    }

    public void _on_Value_pressed()
    {
        if (money.money < grassValuePrice) return;
        
            //money.money -= grassValuePrice;
            general.grassPrice += 0.5f;
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
