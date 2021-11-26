// See https://aka.ms/new-console-template for more information

using GameProject;

GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
gamerManager.Add(new Gamer { Id = 1, BirthYear = 1885, FirstName = "ENGİN", LastName = "DEMİROĞ", İdentityNumber = 12345 });

