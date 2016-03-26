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
    //setters

    public void setNumberOfChildren(int _children_number) 
    {
        this.number_of_children = _children_number;
    }

    public void setMaximumObjects(int _maximum_objects_number) 
    {
        this.maximum_objects = _maximum_objects_number;
    }

    public void setBounds(Point _left_top, Point _right_bottom) {
        this.left_top_bound = _left_top;
        this.right_bottom_bound = _right_bottom;
    }

    public void setParent(ref Quadtree parent_node) {
        this.parent = parent_node;
    }

}
