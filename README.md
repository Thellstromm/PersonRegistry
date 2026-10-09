# Person Registry – Console Application

## Hur bygger och kör man programmet?

Man kan bygga programmet på olika sätt. De två sätten jag har använt mig av är att ha projektet i Visual Studio Community och gå in i Build uppe i menyerna och sen trycka på Build Solution. Det andra sättet är att använda konsolen (Powershell 7 har jag använt mig av). Då tar man sig in i projektets fil och går in i själva projektet, Sen använder man kommandot “dotnet build” för att bygga det. Min pathväg för det ser ut så här: 

C:\Users\Ludwig\source\repos\PersonRegistry\PersonRegistry>. 

För att köra programmet är det i princip samma sak, fast i Visual Studio Community trycker man på play-knappen eller trycker på F5-tangenten för att bygga och köra det på samma gång. I konsolen går man till samma path och skriver kommandot “dotnet run” för att bygga och köra det. 

## Hur har du delat upp programmet mellan olika klasser? Beskriv varför du har valt att göra så.

De modellklasser jag har är Person, Address och Company. Dessa ska representera verkligheten. Jag använder dessa då jag tycker att de passar bra till uppgiften och Address och Company används för att skapa ett objekt av en Person. 

Sen använder jag en PersonDataStore för att spara och skapa listan över personer. PersonService hämtar listan från PersonDataStore och innehåller metoder för att sortera den på olika sätt. Sen till sist har jag en InteractiveUi-klass som hämtar de sorterade listorna från PersonService och skriver ut dem till konsolen. 

## Vad är C# respektive .NET? Nämn en skillnad mellan C# och ett annat programmeringsspråk samt ge exempel på vad man kan utveckla med C#/.NET. 

C# är språket jag har skrivit programmet med. Programmeringsspråket bestämmer syntaxen och hur jag kan skriva variabler, klasser, loppar osv. Samt vilka funktioner som finns som class eller interface.

.NET tar C#-koden och kompilerar den så man kan köra koden. Det kommer även med ett bibliotek av massa färdiga klasser och funktioner man kan använda sig av. C# är designat för att köras med .NET, Utan .NET hade C# bara varit en massa text utan någon möjlighet att köra den. 

En skillnad mellan C# och programmeringsspråket Python är att C# är statiskt typat och Python är dynamiskt typat. Detta innebär att man i C# måste ange typen för en variabel när man skapar den, medan man i Python inte behöver göra det. I C# kontrolleras typerna av kompilatorn innan programmet körs, medan i Python kontrolleras de under körning.

I C# kan bygga:
Konsolappliktioner
Webbapplikationer och AP:er
Desktop-applikationer
mobil- och tvärfplattforms appar
spel
molntjänster och mikrotjämster

## Vad används Visual Studio, Git och PowerShell till vid utveckling med C#/.NET?

Visual Studio är en IDE (Integrated Development Environment) som används som en avancerad textredigerare där man skriver sin kod. Den har funktioner som gör det lättare och snabbare att skriva kod, t.ex. Kodkomplettering (IntelliSense). Den hjälper också till att debugga och hitta fel i koden, så att det blir lättare att rätta till dem.

Git är ett versionshanteringssystem som används för att spara och dela kod med andra. Det sparar olika versioner av koden så att man kan hoppa fram och tillbaka i historiken om man behöver det.

PowerShell är ett kommandoradsverktyg och skriptspråk som används för att bygga och köra sina projekt samt för att hantera Git-kommandon direkt från terminalen.

## Förklara commit och branch

I Git är en commit en sparad ändring med en tillhörande kommentar som kort förklarar vad commiten har gjort med koden. En branch är en parallell utvecklingsmiljö där man kan jobba på något nytt utan att det påverkar huvudkoden (main). Man mergar en branch till main när de nya funktionerna ska implementeras och är redo att användas i huvudkoden.
