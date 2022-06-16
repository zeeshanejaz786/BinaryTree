class Circle : System.IComparable<Circle>
    {
    public Circle( int initialRadius )
        {
        radius = initialRadius;
        }
    public double Area( )
        {
        return Math.PI * radius * radius;
        }
    private double radius;
    public int CompareTo( Circle other )
        {
        if (this.Area() == other.Area())
            return 0;
        if (this.Area() > other.Area())
            return 1;
        return -1;
        }


    }
