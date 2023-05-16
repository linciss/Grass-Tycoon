using Godot;
using System;


public class General : Node
{



    Area2D zero, one, two, three;
    Area2D[] all = new Area2D[4];
    float time = 1f;
    int index = 1;



    public override void _Ready()
    {
        zero = GetNode<Area2D>("/root/Node2D/Node/0");
        one = GetNode<Area2D>("/root/Node2D/Node/1");
        two = GetNode<Area2D>("/root/Node2D/Node/2");
        three = GetNode<Area2D>("/root/Node2D/Node/3");

        all[0] = zero;
        all[1] = one;
        all[2] = two;
        all[3] = three;
    }
    public void _on_1_mouse_entered()

    {
        GD.Print("1");
        for (int i = 1; i < all.Length; i++)
        {
            all[i].Hide();
        }
        time = 1; index = 1;
    }

    public void _on_0_mouse_entered()
    {
        GD.Print("0");
        for (int i = 1; i < all.Length; i++)
        {
            all[i].Hide();
        }
        time = 1; index = 1;
    }

    public void _on_2_mouse_entered()
    {
        GD.Print("2");
    }


    public override void _PhysicsProcess(float delta)
    {

        time -= delta;
        if (time > 0) return;
        for (; index < all.Length;)
        {
            all[index].Show(); index++; time = 1; return;
        }

    }



}


