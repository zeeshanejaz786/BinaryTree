using BinaryTree;



    Tree<int> tree1 = new Tree<int>(100);
    tree1.Insert(50);
    tree1.Insert(110);
    tree1.Insert(-5);
    tree1.Insert(-12);
    tree1.Insert(145);
    tree1.Insert(03);
    tree1.Insert(14);
    tree1.Insert(-8);
    tree1.Insert(160);
    tree1.Insert(86);
    tree1.Insert(38);
    string sortedData = tree1.WalkTree();
    Console.WriteLine($"The Data After Sorthing is: {sortedData}");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Tree<string> tree2 = new Tree<string>("Hello Students");
tree2.Insert("Zeeshan,");
tree2.Insert("fawad,");
tree2.Insert("Usman,");
tree2.Insert("Raza");
tree2.Insert("Today");
tree2.Insert("I");
tree2.Insert("Hope");
tree2.Insert("You");
tree2.Insert("Are");
tree2.Insert("Feeling");
tree2.Insert("Well");
tree2.Insert("!");
sortedData = tree2.WalkTree();
Console.WriteLine($"Sorted data is: {sortedData}");


