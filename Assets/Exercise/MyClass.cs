using UnityEngine;
using System.Collections;
using System;
using XLua;


public struct MyParam1
{
    public int x;
    public int y;
}

[CSharpCallLua]
public interface MyParam2
{
    int x{ get; set; }
    int y { get; set; }
}


[CSharpCallLua]
public delegate int FDelegate(int a);

[XLua.LuaCallCSharp]
public class MyClass 
{
   

    public void ComplexFunc1(MyParam1 p1)
    {
        Debug.Log("P1 = {x=" + p1.x + ",y=" + p1.y + "}");
    }


    public void ComplexFunc(MyParam1 p1, MyParam2 p2)
    {
        Debug.Log("P1 = {x=" + p1.x + ",y=" + p1.y + "}");
        Debug.Log("P1 = {x=" + p2.x + ",y=" + p2.y + "}");
        p2.x = 3;
    }

    public void ComplexFunc2(LuaFunction fun, FDelegate func1)
    {
        ///这里就不加判断了
        fun.Call(1);
        func1(1);
    }

    public void Test() { Debug.Log("csharp callback invoked TEST"); }
    public int ComplexFunc3(
        int a, out int a1,
            MyParam1 p, ref int p1, /// 不能用 ref MyParam1 p1
                Action luafunc, out Action csfunc)
    {
        Debug.Log("ComplexFunc3");
        a1 = 1;
        csfunc = this.Test;
        return 1;
    }

}
