using BinaryTree;

/*
 * Tree for storing integers values and later sorting and traversing the tree
 */

Tree<int> tree1 = new Tree<int>( 100 );
tree1.Insert( 50 );
tree1.Insert( 110 );
tree1.Insert( -5 );
tree1.Insert( -12 );
tree1.Insert( 145 );
tree1.Insert( 03 );
tree1.Insert( 14 );
tree1.Insert( -8 );
tree1.Insert( 160 );
tree1.Insert( 86 );
tree1.Insert( 38 );
string sortedData = tree1.WalkTree();
Console.WriteLine( $"The Data After Sorthing is: {sortedData}" );

Console.WriteLine();
Console.WriteLine();

/*
 * Tree for storing String type values 
 */

Tree<string> tree2 = new Tree<string>( "Hello Students" );
tree2.Insert( "Zeeshan," );
tree2.Insert( "fawad," );
tree2.Insert( "Usman," );
tree2.Insert( "Raza" );
tree2.Insert( "Hashir" );
tree2.Insert( "Khan" );
tree2.Insert( "Ghulam" );
tree2.Insert( "Imran" );
tree2.Insert( "Showbaz" );
tree2.Insert( "Nowaz" );
tree2.Insert( "jawad" );
tree2.Insert( "Adnan" );
sortedData = tree2.WalkTree();
Console.WriteLine( $"Sorted data is: {sortedData}" );

Console.WriteLine();
Console.WriteLine();

/*
 * Circle class is implenting the Icomparable interface so an object of 
 * circle class can be inserted as data inside of a Node of a Binary tree.
 */

Circle circle1 = new Circle( 5 );
Circle circle2 = new Circle( 6 );
Circle circle3 = new Circle( 9 );
Circle circle4 = new Circle( 12 );

Tree<Circle> tree3 = new Tree<Circle>( circle1 );
tree3.Insert( circle2 );
tree3.Insert( circle3 );
tree3.Insert( circle4 );
sortedData = tree3.WalkTree();
Console.WriteLine( $"Sorted data is: {sortedData}" );

/*
 * The output here is just circle because all the circles are just circles
 * are just circles and only thing differing them is their radius and area
 * based on which we placed them on different nodes of tree. And no circle 
 * has any other identifing trait to make it look different in a list of circles.
 */



Console.WriteLine();
Console.WriteLine();

Square square1 = new Square( 5 );
Square square2 = new Square( 6 );
Square square3 = new Square( 9 );

/*
 * This cant happen because the Square Class is not implenting Icomparable interface 
 * and in the definition of Binary Tree we made it required for a class to must be
 * implemting the Icomparable Interface to get access to the compareto() method
 */

//Tree<Square> tree4 = new Tree<Square>( square1 );
//tree4.insert( square1 );
//tree4.Insert( square2 );
//tree4.Insert( square3 );


