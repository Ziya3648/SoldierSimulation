using Core.Entities;

InfantrySolider infantrySolider = new ("Əli", "Əliyevə", 30, "leytenant", 15, false, "AK-74N");
infantrySolider.PerformDuty("Həmlə");


MedicSolider medicSolider = new MedicSolider ("Rauf", "Abbasov", 28, "mayor", 10, false, "Cərrah");
medicSolider.PerformDuty("Cərrahi əməliyyat");

DeveloperEngineerSolider developerEngineerSolider = new DeveloperEngineerSolider("Kamran", "Ağayev", 24, "baş leytenant", 5, false, "Şəbəkə inzibatçısı");
developerEngineerSolider.PerformDuty("Şəbəkəni sazlamaq");

