# Oprette en miljøvariabel på Linux (Erstat <din_environment_variabel> med hav den nu engang er)

1) Åbn et terminalvindue, f.eks. i VS Code

2) Eksekver følgende
echo 'export GITHUB_TOKEN="<din_environment_variabel>"' >> ~/.bashrc
source ~/.bashrc

..Man kan egentlig også bare åbne filen .bashrc, som ligger i ens Home directory (som man kan komme til ved bare at eksekvere: cd ~) og så skrive export GITHUB_TOKEN="<dit_token>"

(Det er nødvendigt for at man kan hente nuget pakker fra GitHub Packages)

# Bygge en konsolapplikation såsom DMI.StatDB.UI.Console
1) Åbn et terminalvindue, f.eks. i VS Code
2) Eksekver evt: dotnet restore
3) Naviger til projektfolderen for command line applikationen ved f.eks. at eksekvere: cd DM.StatDB.UI.Console
4) Eksekver: dotnet build

# Eksekvere selve applikationen på Linux (uafhængigt af IDE)
1) Sikr, at konsolapplikationen er bygget (der skal ligge en fil ved navn DMI.StatDB.UI.Console.dll i folderen bin/Debug/net8.0)
2) Åbn et terminalvindue og naviger hen til foldere med den nævnte dll
3) Eksekver f.eks: dotnet DMI.StatDB.UI.Console.dll breakfast

# Debugge en konsolapplikation med VS Code på Linux
1) Sikr, at du har den nødvendige extension installeret (C# Dev Kit og/eller C#)
2) Åbn solution folderen, dvs folderen DMI.StatDB
3) I hovedmenuen, vælg Run->Add Configuration
4) Vælg C# som debugger. Bemærk, hvordan VS Code nu laver en folder ved navn .vscode med en (ret tom) launch.json fil
5) I hovedmenuen, vælg igen Run->Add Configuration
6) Vælg nu ".NET: Launch C# project". Bemærk, hvordan VS Code nu tilføjer en blok til launch.json filen
7) Korriger den linie i launch.json filen, der starter med projectPath, så den peger på den rigtige .csproj fil
8) Korriger også den linie i launch.json filen, der starter med name
Bemærk, at launch.json-filen befinder sig på solution niveau.
9) Lav en folder ved navn "Properties" i projektfolderen (DMI.StatDB.UI.Console) og lav heri en fil ved navn launchSettings.json med følgende indhold:
{
  "profiles": {
    "DMI.StatDB.UI.Console": {
      "commandName": "Project",
      "commandLineArgs": "export"
    }
  }
}
(Det er det samme, som Visual Studio vil gøre, hvis man åbner Properties for et projekt og dernæst Debug)
10) Hvis man nu i hovedmenuen vælger Run->Start debugging (eller bare trykker F5) eksekverer man nu konsolapplikationen med de anførte input parametre
Bemærk, at metoden benytter både launch.json-filen og launchSettings.json filen. Den første specificerer så at sige HVILKET projekt, der skal eksekveres (som hvis det var valgt Startup projekt i Visual Studio), og den anden specificerer HVORDAN, f.eks. mht input parametre.
Ifølge ChatGpt er det en helt naturlig arbejdsdeling, også med udgangspunkt i, at VS Code i dens perspektiv er et "lightweight" IDE.
