using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        B b = new B();

    }
}

class A
{
    public int a;
    private int b;
    protected int c;

    protected void SetB(int v)
    {
        this.b = v;
    }
}

class B : A
{

    public B()
    {
        this.SetB(1);
    }
}

