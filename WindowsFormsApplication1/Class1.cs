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

    ////////////////////////////    CLASS FIELDS   /////////////////////////////////

    private int maximum_objects = 2;
    private int number_of_children = 0;
    private Point left_top_bound;       //bounds are two points: top left corner of an rectangle and bottom right corner
    private Point right_bottom_bound;      //consequently, this is rectangle diagonale line in common
    Quadtree parent = new Quadtree();
    Quadtree north_west = new Quadtree();
    Quadtree north_east = new Quadtree();
    Quadtree south_west = new Quadtree();
    Quadtree south_east = new Quadtree();

    /////////////////////////////   CLASS METHODS   /////////////////////////////
    //setters/getters

    public int NumberOfChildren
    {
        set { this.number_of_children = value ;}
        get { return this.number_of_children; }
    }

    public int MaximumObjects    
    {
        set { this.maximum_objects = value; }
        get { return this.maximum_objects; }
    }

    public Point LeftTopBound 
    {
        set { this.left_top_bound = value; }
        get { return this.left_top_bound; }
    }

    public Point RightBottomBound
    {
        set { this.right_bottom_bound = value; }
        get { return this.right_bottom_bound; }
    }

    public Quadtree setParent {
        set { this.parent = value; }
        get { return this.parent; }
    }

    
}
