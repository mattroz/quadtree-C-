using System;
using System.Data;
using System.Drawing;

public class Quadtree
{
    //constructor
	public Quadtree()
	{
	}

    //destructor
    public ~Quadtree()
    { 
    }

    //class fields
    private int maximum_objects = 2;
    private int number_of_children = 0;
    private Point left_top_bound;
    private Point right_bot_bound;
    Quadtree parent = new Quadtree();
    Quadtree north_west = new Quadtree();
    Quadtree north_east = new Quadtree();
    Quadtree south_west = new Quadtree();
    Quadtree south_east = new Quadtree();
}
