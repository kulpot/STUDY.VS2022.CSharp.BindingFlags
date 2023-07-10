using System;
using System.Linq;
using System.Reflection;
using BFF = System.Reflection.BindingFlags;

//ref link:https://www.youtube.com/watch?v=Snitr4Ck-CY&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=26
//  

class Cow
{
    public string Name { get; set; }
    public int Age { get; set; }
    private int NumHeartBeats { get; set; }
    public void Beat() { NumHeartBeats++; }
    private void Digest() { Console.WriteLine("grind grind..."); }
    static void WhateverStaticMethod() { }
}

class MainClass
{
    static void Main()
    {
        IEnumerable<MemberInfo> members =
            //typeof(Cow).GetMembers().OrderByDescending(mi => mi.DeclaringType.Name);
            typeof(Cow).GetMembers();
            //typeof(Cow).GetMembers( BFF.DeclaredOnly | BFF.Instance | BFF.Public | BFF.Static | BFF.NonPublic);
        foreach(MemberInfo minfo in members)
            Console.WriteLine(minfo);
    }
}