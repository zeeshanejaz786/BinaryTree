class Square
    {
    public Square( int width )
        {
        length = width;
        }
    public double Area( )
        {
        return length * length;
        }
    private double length;

    public int CompareTo( object obj )
        {
        Square sqrObj = (Square)obj;
        if (this.Area() == sqrObj.Area())
            return 0;
        if (this.Area() > sqrObj.Area())
            return 1;
        return -1;
        }

    }