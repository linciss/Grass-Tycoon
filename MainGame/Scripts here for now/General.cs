using Godot;
using System;


public class General : Node
{



    Area2D p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;
    Area2D[] all = new Area2D[10];
    float time = 1f;
    int index = 0;
    [Export] NodePath[] path;
    bool cropped = false;



    public override void _Ready()
    {
        p1 = GetNode<Area2D>(path[0]);
        p2 = GetNode<Area2D>(path[1]);
        p3 = GetNode<Area2D>(path[2]);
        p4 = GetNode<Area2D>(path[3]);
        p5 = GetNode<Area2D>(path[4]);
        p6 = GetNode<Area2D>(path[5]);
        p7 = GetNode<Area2D>(path[6]);
        p8 = GetNode<Area2D>(path[7]);
        p9 = GetNode<Area2D>(path[8]);
        p10 = GetNode<Area2D>(path[9]);

        all[1] = p2;
        all[2] = p3;
        all[3] = p4;
        all[4] = p5;
        all[5] = p6;
        all[6] = p7;
        all[7] = p8;
        all[8] = p9;
        all[9] = p10;
    }

    public void _on_p1_mouse_entered()
    {
        GD.Print("0");
    }
    public void _on_p2_mouse_entered()

    {
        GD.Print("1");
        for (int i = 1; i < all.Length; i++)
        {
            all[i].Hide();
        }
        time = 1; index = 1; cropped = true;
    }

    public void _on_p3_mouse_entered()
    {
        GD.Print("2");
        for (int i = 2; i < all.Length; i++)
        {
            all[i].Hide();
        }
        time = 1; index = 2; cropped = true;
    }

    public void _on_p4_mouse_entered()
    {
        GD.Print("3");
        for (int i = 3; i < all.Length; i++)
        {
            all[i].Hide();
        }
        time = 1; index = 3; cropped = true;
    }

    public void _on_p5_mouse_entered()
    {
        GD.Print("4");
        for (int i = 4; i < all.Length; i++)
        {
            all[i].Hide();
        }
        time = 1; index = 4; cropped = true;
    }

    public void _on_p6_mouse_entered()
    {
        GD.Print("5");
        for (int i = 5; i < all.Length; i++)
        {
            all[i].Hide();
        } 
        time = 1; index = 5; cropped = true;
    }

    public void _on_p7_mouse_entered()
    {
        GD.Print("6");
        for (int i = 6; i < all.Length; i++)
        {
            all[i].Hide();
        }
        time = 1; index = 6; cropped = true;
    }

    public void _on_p8_mouse_entered()
    {
        GD.Print("7");
        for (int i = 7; i < all.Length; i++)
        {
            all[i].Hide();
        }
        time = 1; index = 7; cropped = true;
    }

    public void _on_p9_mouse_entered()
    {
        GD.Print("8");
        for (int i = 8; i < all.Length; i++)
        {
            all[i].Hide();
        }
        time = 1; index = 8; cropped = true;
    }

    public void _on_p10_mouse_entered()
    {
        GD.Print("9");
        for (int i = 9; i < all.Length; i++)
        {
            all[i].Hide();
        }
        time = 1; index = 9; cropped = true;
    }


    public override void _PhysicsProcess(float delta)
    {

        time -= delta;
        if (time > 0) return;
        if (!cropped) return;

        for (; index < all.Length;)
        {
            all[index].Show(); index++; time = 1; return;
        }

    }



}


