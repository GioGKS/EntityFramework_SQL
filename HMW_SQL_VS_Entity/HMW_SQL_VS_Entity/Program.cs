using System;
using HMW_SQL_VS_Entity.FootballTeam;
using Microsoft.EntityFrameworkCore;

CreatePlayer somePlayer = new CreatePlayer();
somePlayer.OpeningHelpList();

int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1:
        somePlayer.CreateEntity();
        break;
    case 2:
        somePlayer.DeleteEntity();
        break;
    case 3:
        somePlayer.UpdateEntity();
        break;
    case 4:
        somePlayer.EntityDetails();
        break;
    case 5:
        somePlayer.ListOfEntities();
        break;
    default:
        Console.WriteLine("!!! __________Wrong Number. Closing The APP__________ !!!\n");
        break;
    
}
