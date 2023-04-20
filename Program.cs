﻿// See https://aka.ms/new-console-template for more information

using SimpleFactoryPattern;

Console.WriteLine("*** Simple Factory Pattern Demo***\n");
IAnimal preferredType=null;
ISimpleFactory simpleFactory = new SimpleFactory();            
#region The code region that will vary based on users preference            
preferredType = simpleFactory.CreateAnimal();            
#endregion
#region The codes that do not change frequently
preferredType.Speak();
preferredType.Action();
#endregion
Console.ReadKey();