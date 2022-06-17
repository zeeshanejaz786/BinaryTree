
using BinaryTree;
class Student : System.IComparable<Student>, IPrinttree
    {

    public Student( String name, int age, double Cgpa )
        {
        Name = name;
        Age = age;
        CGPA = Cgpa;
        }
    public string Name { get; set; }
    public int Age { get; set; }
    public double CGPA { get; set; }

    public int CompareTo( Student n )
        {
        if (this.CGPA == n.CGPA)
            return 0;
        if (this.CGPA > n.CGPA)
            return 1;
        return -1;
        }

    public string PrintNode( )
        {
        string NodeData = "Student " + this.Name + " has a CGPA " + this.CGPA.ToString();
        return NodeData;
        }
    }