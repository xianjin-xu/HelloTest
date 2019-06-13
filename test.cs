using System;

class A
{
 	public A()
   	{
      	PrintFields();
   	}

	public virtual void PrintFields() {}
}

class B : A
{ 
	int x = 1;
	int y;

	public B()
	{
		y = -1;
	}

	public override void PrintFields()
	{
		Console.WriteLine("x={0}, y={1} ", x, y);
	}

  public static void Main(params object[] args) {
    Console.WriteLine("test start");
    var b = new B();
    b.PrintFields();
		var a = b as A;
		a.PrintFields();
    //Console.ReadLine();
  }
}
