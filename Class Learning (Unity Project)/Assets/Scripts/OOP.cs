using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Monobehaviours can be attached to Unity game objects
public class OOP : MonoBehaviour
{
    private void Start()
    {
        Fish fish;  //create an empty variable that stores fish data type
        //instantiate fish and store in variable
        fish = new Fish("Paratilapia polleni", 7);
        fish.PrintAnimal(); //call PrintAnimal method from fish
    }
}

//Abstract classes can only be inherited from, not instantiated
public abstract class Animal
{
    //encapsulated data can only be changed from within the class
    private string name;
    private int age;

    public Animal(string _name, int _age) //class constructor for instantiating the object
    {
        name = _name;
        age = _age;
    }

    //abstract method must be implemented in all derived (child) classes
    public abstract void Eat();
    public abstract void Eat(string food);

    //Virtual method may have implementation overriden 
    public virtual void PrintAnimal()
    {
        Debug.Log("Name: " + name);
        Debug.Log("Age: " + age);
    }
}


public class Fish : Animal //Fish class inherits the animal class
{
    //Fish Constructor
    //Passes parameters to base class constructor
    public Fish(string _name, int _age) : base(_name, _age)
    {

    }

    //Override version of Animal's Eat method
    public override void Eat()
    {
        Debug.Log("Fish is eating.");
    }

    public override void Eat(string food)
    {
        Debug.Log("Fish has eaten " + food);
    }
    //Extended version of Animal's PrintAnimal method
    public override void PrintAnimal()
    {
        base.PrintAnimal();
        Debug.Log("This is a fish.");
    }
}

