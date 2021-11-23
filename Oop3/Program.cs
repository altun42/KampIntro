// See https://aka.ms/new-console-template for more information

using Oop3;

IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
IKrediManager tasıtKrediManager = new TasıtKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

List<ILoggerService> loggers = new List<ILoggerService>() { fileLoggerService,databaseLoggerService};


BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager,loggers );


List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasıtKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);