using System.Security.Cryptography;

namespace ObjectOrientedProgramming;
/// <summary>
/// Abstraction is showing definition and hiding implementation.
/// </summary>
public class T10_Abstraction
{
    public void Test()
    {
        //cannot instantiate abstract class
        //KitchenMenuAbstractClass a = new KitchenMenuAbstractClass();
        
    }
    public abstract class KitchenMenuAbstractClass
    {
        //functions
        public abstract void MakeTea();
        public abstract void MakeCoffee();
        public abstract void MakeBreakfast();
    }
    /// <summary>
    /// KitchenRoom class is implementing the behaviour of 
    /// kitchenMenuAbstractClass
    /// </summary>
    public class KitchenRoom : KitchenMenuAbstractClass//Contract between two classes
    {
        public override void MakeTea()
        {
            //step 1;
            //step 2;
        }
        public override void MakeCoffee()
        {

        }
        public override void MakeBreakfast()
        {
            
        }
    }

    public abstract class A
    {
        public abstract void A1();
    }
    public abstract class B : A
    {
        public abstract void B1();
    }
    public class C : B
    {
        public override void A1()
        {
            throw new NotImplementedException();
        }

        public override void B1()
        {
            throw new NotImplementedException();
        }
    }

    //Abstraction using interface

    public interface ICar
    {
        public void Start();
        public void Stop();
        public void Accelerate();
        public void Break();
        public void Turn();
    }
    public class Car : ICar
    {
        public void Accelerate()
        {
        }

        public void Break()
        {
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }

        public void Turn()
        {
        }
    }

    //used as multiple inheritance
    public interface IPerson
    {
        public void PrintName();
        public void PrintAddress();
    }
    public interface ITeacher : IPerson
    {
        public void PrintDesignation();
    }
    public interface IStudent
    {
        public void PrintMarks();
    }
    public class Student : IPerson, IStudent
    {
        public void PrintAddress()
        {
           
        }

        public void PrintMarks()
        {
           
        }

        public void PrintName()
        {
           
        }
    }
    public class Teacher : ITeacher
    {
        public void PrintAddress()
        {
            throw new NotImplementedException();
        }

        public void PrintDesignation()
        {
            throw new NotImplementedException();
        }

        public void PrintName()
        {
            throw new NotImplementedException();
        }
    }

}
