using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bird
{
    int wings  = 2;
    int legs   = 2;

    public void fly()
    {
        Debug.Log("I am flying.");
    }

    public void sing()
    {
        Debug.Log("I am singing.");
    
    }
}

public class Cat
{
    int legs  = 4;
    int tail  = 1;

    public void walk()
    {
        Debug.Log("I am walking");
    }

    public void sing()
    {
        Debug.Log("I am singing");
    }
}


public class Crow : Bird
{
    Bomb bomb01 = new Bomb();

    public void attack()
    {
        bomb01.explod();
    }
    public void steal()
    {
        Debug.Log("I am stealing");
    }
}

public class Bomb
{
    public void explod()
    {
        Debug.Log("Booooooommm!!!");
    }
}

   


public class Dog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Bird punpun = new Bird();
        Bird jackky = new Bird();
        Crow somsom = new Crow();

        punpun.fly();
        jackky.fly();
        somsom.steal();

        Cat cat = new Cat();

        cat.walk();

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
