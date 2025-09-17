namespace ObjectOrientedProgramming;
/// <summary>
/// Inheritance is used to avoid Code Repetition
/// The members of parent class/base class/super class is 
/// inherited to child class/derived class/sub class
/// Types of Inheritance:
/// 1. Single
/// 2. Multilevel
/// 3. Hierarchical
/// 4. Hybrid
/// 5. Multiple (Not Allowed)
/// </summary>
public class T09_Inheritance
{
    public void Test()
    {
        Child1Class c1 = new Child1Class();
        Child2Class c2 = new Child2Class();
    }
    public class ParentClass
    {
        //Class Members will be available in derived classes
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Field;
        public void Test()
        {

        }
        public class A
        {

        }
        public struct B
        {

        }
    }
    public class Child1Class : ParentClass
    {

    }
    public class Child2Class : ParentClass
    {

    }

    //Types of Inheritance
    //1. Single has single base and single derived
    public class SingleBase
    {

    }
    public class SingleDerived : SingleBase
    {

    }

    //2. Multilevel - it has more than two levels
    public class MultilevelA
    {

    }
    public class MultilevelB : MultilevelA
    {

    }
    public class MultilevelC : MultilevelB
    {

    }

    //3. Hierarchical - Parent will have more than one child class
    public class HierarchicalBase
    {

    }
    public class HierarchicalDerived1 : HierarchicalBase
    {

    }
    public class HierarchicalDerived2 : HierarchicalBase
    {

    }

    //4. Hybrid

    public class HybridBase
    {

    }
    public class HybridDerived1 : HybridBase
    {

    }
    public class HybridDerived2 : HybridBase
    {

    }
    public class HybridDerived3 : HybridDerived1
    {

    }

    //Multiple - A child class will have more than one parent
    public class MultipleBase1
    {
        public string Name { get; set; }
    }
    public class MultipleBase2
    {
        public string Name { get; set; }
    }
    //Following inheritance with two base classes is not allowed
    public class MultipleDerived : MultipleBase1 //, MultipleBase2
    {

    }
    //This is allowed only by using interfaces, BUT IT IS NOT INHERITANCE (IT IS ABSTRACTION).
    public interface Base1Interface
    {

    }
    public interface Base2Interface
    {

    }
    public class DerivedClass : Base1Interface, Base2Interface
    {

    }
}
