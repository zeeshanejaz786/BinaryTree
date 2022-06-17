using BinaryTree;

Student student1 = new Student( "Zeeshan", 21, 3.5 );
Student student2 = new Student( "Fawad", 21, 3.0 );

Tree<Student> StudentTree = new Tree<Student>( student1 );
StudentTree.Insert( student2 );
string sortedData = StudentTree.WalkTree();
Console.WriteLine( $"Sorted data is: {sortedData}" );



///*
// * Tree for storing integers values and later sorting and traversing the tree
// */

//Tree<int> tree1 = new Tree<int>( 100 );
//InsertIntoTree<int>( ref tree1, 1, 50, 70, 89, -89, 56, -98875, 776, 36, 89, 334 );


//string sortedData = tree1.WalkTree();
//Console.WriteLine( $"The Data After Sorthing is: {sortedData}" );

//Console.WriteLine();

///*
// * Tree for storing String type values 
// */

//Tree<string> tree2 = new Tree<string>( "Hello Students" );
//InsertIntoTree<string>( ref tree2, "Zeeshan,", "Adil,", "Usman,", "Raza", "Hashir", "Khan" );

//sortedData = tree2.WalkTree();
//Console.WriteLine( $"Sorted data is: {sortedData}" );

//Console.WriteLine();

///*
// * Circle class is implenting the Icomparable interface so an object of 
// * circle class can be inserted as data inside of a Node of a Binary tree.
// */

//Circle circle1 = new Circle( 5 );
//Circle circle2 = new Circle( 6 );
//Circle circle3 = new Circle( 9 );
//Circle circle4 = new Circle( 12 );

//Tree<Circle> tree3 = new Tree<Circle>( circle1 );
//tree3.Insert( circle2 );
//tree3.Insert( circle3 );
//tree3.Insert( circle4 );
//sortedData = tree3.WalkTree();
//Console.WriteLine( $"Sorted data is: {sortedData}" );

///*
// * The output here is just circle because all the circles are just circles
// * are just circles and only thing differing them is their radius and area
// * based on which we placed them on different nodes of tree. And no circle 
// * has any other identifing trait to make it look different in a list of circles.
// */



//Console.WriteLine();

//Square square1 = new Square( 5 );
//Square square2 = new Square( 6 );
//Square square3 = new Square( 9 );

///*
// * This cant happen because the Square Class is not implenting Icomparable interface 
// * and in the definition of Binary Tree we made it required for a class to must be
// * implemting the Icomparable Interface to get access to the compareto() method
// */

////Tree<Square> tree4 = new Tree<Square>( square1 );
////tree4.insert( square1 );
////tree4.Insert( square2 );
////tree4.Insert( square3 );



///*
// *  A generic function for inserting items to a tree without 
// *  calling the insert funtion again and again
// */

//static void InsertIntoTree<TItem>( ref Tree<TItem> tree, params TItem[] data )
//where TItem : IComparable<TItem>
//    {
//    foreach (TItem datum in data)
//        {
//        if (tree is null)
//            {
//            tree = new Tree<TItem>( datum );
//            }
//        else
//            {
//            tree.Insert( datum );
//            }
//        }
//    }


