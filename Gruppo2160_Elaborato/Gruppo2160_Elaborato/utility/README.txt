## Come Utilizzare l'applicazione 
* Per prima cosa occorre avere installato mySQL attraverso l'installer al link: https://dev.mysql.com/downloads/installer/
* Occorre installare uno strumento visuale di progettazione per database ad esempio MySQL Workbench a questo link https://dev.mysql.com/downloads/workbench/
* Scaricare il file zip disponibile all'interno della release e decomprimerlo all'interno di una cartella vuota
* Si può procedere alla creazione del database e delle tabelle eseguendo le query presenti nel file ".\utility\create.sql"
* Nel file ".\ChessTournament_DB\WindowsFormApp\bin\Release\netcoreapp3.1\WindowsFormApp.dll.config", se necessario modificare la connection string ed inserire la password di root del database
* Aprire il file .\ChessTournament_DB\ChessTournament.sln con Visual Studio (testato con VS2019) 
* Eseguire il login con un utente qualunque (credenziali disponibili nel file "credenziali.txt") oppure registrarsi ed effettuare il login con le credenziali inserite in fase di registrazione