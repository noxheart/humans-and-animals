# humans-and-animals

En person besöker en djurpark (animal sanctuary). I djurparken finns det olika typer av djur:
* Elefanter
* Giraffer
* Prärievargar
* Sälar
* Björnar

Alla djur har ett eget namn och en hunger nivå. Hunger nivån börjar alltid på 0.

* Elefanter & Giraffer äter blad.
* Prärievargar och Sälar äter kött.
* Björnar kan äta både blad och kött.

### Del 1 ⭐️

Skapa en lista med olika djur som finns i djurparken, minst ett av varje typ av djur - men gärna fler.

### Del 2 ⭐️⭐️

Varje dag vill djurskötarna see vilka djur som behöver matas, skriv ut Main i Program klassen som kan kan simulera ett förlopp av dagar och matning av varje djur.

Börja med följande kodstycke i main:
```c#
// Day loop
int nrOfMeatLeft = 50;
int nrOfVeggiesLeft = 50;
int day = 0;
while (true) {
  day++;
  Console.WriteLine("Det är dag " + day + ":");
  Console.WriteLine("-------");
  
  // LÄGG TILL DIN NYA KOD HÄR
  
  // Wait for the next day
  Console.ReadKey();
}

```

Hungernivån på varje individuellt djur ska öka med 1 varje dag. Varje djur är hungriga när nivån når följande nivåer:

* Elefanter: 10
* Giraffer: 7
* Prärievargar: 15
* Sälar: 13
* Björnar: 3

Du behöver skriva en metod för varje djur som gör följande:
* Ökar hungernivån
* Kollar om djuret behöver äta eller inte
* Konsumerar mat och återställer hungernivån

Fundera på följande:

 Behöver den aktuella hungernivån för varje djur vara public?
 
 Vart ska koden för att visa varje djurs hungernivå ligga?
