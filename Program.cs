// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;

#region Arrays

string[] deneme = {"asd", "asd"};
string[] deneme1 = new string[2] {"asd", "asd"};
string[,] deneme2 = {{"1", "2"}, {"3", "4"}};
//Console.WriteLine(deneme2[0, 0].ToString());

List<int> listvalues = new List<int>();
listvalues.Add(1);

//Tuple
var person = GetPerson();
//Console.WriteLine(person.Item1.ToString());
//Console.WriteLine(person.Item2.ToString());

Tuple<int, string, string> GetPerson()
{
    return Tuple.Create(1, "Erdem", "e_savar@hotmail.com");
}

#endregion

#region params

int topla(params int[] numbers)
{
    int top = 0;
    foreach (int item in numbers)
    {
        top += item;
    }

    return top;
}

//Console.WriteLine(topla(1,3,4).ToString());

#endregion

#region Enums

Rent rent = new Rent {Status = RentStatus.Create};

string result = (rent.Status.Equals(RentStatus.Create)) ? "Ok" : "Nok";

// Console.WriteLine(result);
//
// Console.WriteLine(Enum.Parse(typeof(RentStatus),"Create"));
// Console.WriteLine(Enum.GetName(typeof(RentStatus),2));

#endregion

#region Yield

IEnumerable<Player> GetPlayerYieldList()
{
    for (int i = 0; i < 10; i++)
    {
        yield return new Player() {Id = i, FullName = $"Player{i}", Company = "Squad"};
    }
}

var players = GetPlayerYieldList();

foreach (var player in players)
{
    Console.WriteLine($"Id:{player.Id.ToString()}-Name:{player.FullName}-Company:{player.Company}");
}

#endregion

class Rent
{
    public RentStatus Status { get; set; }
}

class Player
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Company { get; set; }
}

