using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleOOP : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Mercedes m = new Mercedes(100);
        m.Drive();
    }

    
}

public abstract class Vehicle
{
    private int speed;

    public Vehicle(int _speed)
    {
        speed = _speed;
    }

    public virtual void Drive()
    {
        Debug.Log("Driving at " + speed + " KMH. ");
    }
}



public class Mercedes : Vehicle
{
    public Mercedes(int _speed) : base(_speed)
    {

    }

    public override void Drive()
    {
        Debug.Log("Car is Driving. ");
    }
}