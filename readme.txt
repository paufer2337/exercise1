=== C# Övning 1 - Personalregister ===


¤ Uppgift 1:

- Vilka klasser bör ingå i programmet?

Svar: Program (UI+meny) och Employee (Personaldata/modal)

========================================================================|

¤ Uppgift 2:

- Vilka attributer och metoder bör ingå i dessa klasser?

Svar: 
   ~ Attribut:
    |    firstName, lastName, Salary, Name* (* = string -> readonly).   |

   ~ Metoder:
    |    Main       = Styr menyn/programmet i en loop                   |
    |    AddEmp     = Lägger till ny asntälld                           |
    |    ListAllEmp = Listar upp alla tillagda anställda                |
    |    UpdateEmp  = Updaterar/redigerar anställd                      |   
    |    DeleteEmp  = Tar bort/raderar en anställd                      |

========================================================================|

¤ Uppgift 3:
- Se/kör Program.cs

cmd:
dotnet run

========================================================================|


~ Tack för mig ~