# Egde - Blazor Workshop @ UiA 02.09-03.09
Først og fremst, velkommen til Egdes Blazor Workshop. Det fiktive biblioteket "Egdes Library 4 Dummies" ønsker seg et 
brukergrensesnitt for utlån av bøker. Ett annet firma har allerede laget ett API som håndterer innlevering og utlevering av bøker.
Din jobb vil være å lage ett brukergrensesnitt som gir bibliotekaren et verktøy til sin daglige jobb.

Brukergrensesnittet skal ha følgende funksjoner:
- Opplisting av alle bøker med visning av utlånsstatus
- Skjema med inputfelter, radiobuttons / dropdown og buttons for å legge til eller endre en bok
- Mulighet for å slette en bok
- Mulighet for å låne en bok
- Mulighet for å levere en bok tilbake og gjøre den tilgjengelig for nytt utlån

Har du spørsmål, rekk bare opp hånden og vi vil hjelpe deg så fort vi kan! :)

### Forutsetninger
For å kunne kjøre applikasjonen, krever det at du har følgende installert:
* Visual Studio
* .NET SDK (nyeste versjon), se https://dotnet.microsoft.com/learn/aspnet/blazor-tutorial/install
* Last ned frontendappen fra GitHub eller opprett en Blazor WebAssembly app
For mer info for å komme i gang se: https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/intro
For info om Blazor se: https://blazor-university.com/

### Oppstart av applikasjonen
Åpnet først .sln filen i Visual Studio.

Velg så via Run-knappens "pil-ned" og "Browse With..." velge hvilken nettleser du vil kjøre appen i.
Vi anbefaler å bruke enten Google Chrome eller Microsoft Edge Chromium.

Via Run-knappens "pil-ned" velger du så "BlazorWorkshopFrontend" for å kjøre appen via Kestrel i stedet for IISExpress (litt kulere debugging og den kjører default på port 5001).

Du kjøre frontendappen lokalt via F5 eller Run-knappen.
Appen vil da automatisk åpne og starte opp i din valgte nettleser.
Oppdateringer ved kjørende app kan du gjøre via Ctrl+Shift+F5 eller via Restart-knappen.

### Komponentbiblioteker
Vi har lagt inn Radzen Blazor Components i prosjektet som dere kan benytte i deres lokale komponenter i biblioteksappen.
For info om disse se: https://blazor.radzen.com/