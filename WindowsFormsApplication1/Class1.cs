using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;


public class Quadtree
{
    //constructor
	public Quadtree(Point _left_bound, Point _right_bound)
	{
        this.LeftTopBound = _left_bound;
        this.RightBottomBound = _right_bound;
        this.Subdivide();
	}


    ////////////////////////////    CLASS FIELDS   /////////////////////////////////
    private const int DEFAULT_MAX_OBJ = 2;

    private int maximum_objects = 2;
    private int number_of_children = 0;
    private List<Point> points = new List<Point>();

    private Point left_top_bound;       //bounds are two points: top left corner of an rectangle and bottom right corner
    private Point right_bottom_bound;      //consequently, this is rectangle diagonale line in common
    
    Quadtree parent;
    Quadtree north_west;
    Quadtree north_east;
    Quadtree south_west;
    Quadtree south_east;

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

    public Quadtree Parent 
    {
        set { this.parent = value; }
        get { return this.parent; }
    }

    //basic Quadtree methods

    public void Subdivide() 
    {
        Point nw_left, nw_right,
              ne_left, ne_right,
              sw_left, sw_right,
              se_left, se_right;

        //north-west bound
        nw_left = this.LeftTopBound;
        nw_right.X = this.RightBottomBound.X / 2;
        nw_right.Y = this.RightBottomBound.Y / 2;

        // calculate north-east bound, seems horrible
        ne_left.X = this.LeftTopBound.X + (this.LeftTopBound.X + this.RightBottomBound.X) / 2 ;
        ne_left.Y = this.LeftTopBound.Y;
        ne_right.X = this.RightBottomBound.X;
        ne_right.Y = this.LeftTopBound.Y + this.RightBottomBound.Y / 2;

        //south-west bound
        sw_left.X = this.LeftTopBound.X;
        sw_left.Y = this.LeftTopBound .Y + this.RightBottomBound.Y / 2;
        sw_right.X = ne_left.X;
        sw_right.Y = this.RightBottomBound.Y / 2;

        //south-east bound
        se_left = nw_right;
        se_right = this.RightBottomBound;

        this.north_west = new Quadtree(nw_left, nw_right);
        this.north_east = new Quadtree(ne_left, ne_right);
        this.south_west = new Quadtree(sw_left, sw_right);
        this.south_east = new Quadtree(se_left, se_right);
    }

    public void Insert(Point _point)
    {
        this.points.Add(_point);
    }
}
