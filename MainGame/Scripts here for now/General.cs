using Godot;
using System;


public class General : Area2D
{



    Area2D p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;
    Area2D[] all = new Area2D[10];
    public float growthTime = 1f;
    int index = 0, grassPieces = 9, bladesCut = 0;
    [Export] NodePath[] path;
    bool cropped = false;
    Money money;
    

    


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
        money = (Money)GetNode("/root/Money");
    }

    public void _on_p1_mouse_entered()
    {
      
    }
    public void _on_p2_mouse_entered()

    {
        for (int i = 1; i < all.Length; i++)
        {
            all[i].Hide();   
        }
        growthTime = money.growthTime; index = 1; cropped = true;

        bladesCut = grassPieces - index;
        grassPieces = 1;
        money.cutGrass(bladesCut);

    }

    public void _on_p3_mouse_entered()
    {
        for (int i = 2; i < all.Length; i++)
        {
            all[i].Hide();
            
        }
        growthTime = money.growthTime; index = 2; cropped = true;

        bladesCut = grassPieces - index;
        grassPieces = 2;
        money.cutGrass(bladesCut);
    }

    public void _on_p4_mouse_entered()
    {
        for (int i = 3; i < all.Length; i++)
        {
            all[i].Hide();
        }
        growthTime = money.growthTime; index = 3; cropped = true; 
        
        
        bladesCut = grassPieces - index;
        grassPieces = 3;
        money.cutGrass(bladesCut);
    }

    public void _on_p5_mouse_entered()
    {
        for (int i = 4; i < all.Length; i++)
        {
            all[i].Hide();
        }
        growthTime = money.growthTime; index = 4; cropped = true;

        bladesCut = grassPieces - index;
        grassPieces = 4;
        money.cutGrass(bladesCut);
    }

    public void _on_p6_mouse_entered()
    {
        
        for (int i = 5; i < all.Length; i++)
        {
            all[i].Hide();
        } 
        growthTime = money.growthTime; index = 5; cropped = true;

        bladesCut = grassPieces - index;
        grassPieces = 5;
        money.cutGrass(bladesCut);
    }

    public void _on_p7_mouse_entered()
    {
      
        for (int i = 6; i < all.Length; i++)
        {
            all[i].Hide();
        }
        growthTime = money.growthTime; index = 6; cropped = true;

        bladesCut = grassPieces - index;
        grassPieces = 6;
        money.cutGrass(bladesCut);
    }

    public void _on_p8_mouse_entered()
    {
      
        for (int i = 7; i < all.Length; i++)
        {
            all[i].Hide();
        }
        growthTime = money.growthTime; index = 7; cropped = true;

        bladesCut = grassPieces - index;
        grassPieces = 7;
        money.cutGrass(bladesCut);
    }

    public void _on_p9_mouse_entered()
    {
       
        for (int i = 8; i < all.Length; i++)
        {
            all[i].Hide();
        }
        growthTime = money.growthTime; index = 8; cropped = true;

        bladesCut = grassPieces - index;
        grassPieces = 8;
        money.cutGrass(bladesCut);
    }

    public void _on_p10_mouse_entered()
    {
        
        for (int i = 9; i < all.Length; i++)
        {
            all[i].Hide();
        }
        growthTime = money.growthTime; index = 9; cropped = true;

        bladesCut = grassPieces - index;
        grassPieces = 9;
        money.cutGrass(bladesCut);
    }

    public override void _PhysicsProcess(float delta)
    {
        growthTime -= delta;
        if (growthTime > 0) return;
        if (!cropped) return;

        for (; index < all.Length;)
        {
            all[index].Show(); grassPieces++; index++; growthTime = money.growthTime; return;
        }

    }

  



}


