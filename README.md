# ChessTournament

Un software per gestire i tornei di scacchi

## Funzionalità disponibili
- [x] Possibilità di registrarsi e fare login. 
- [x] Partecipare ad un edizione di un torneo se si accede come giocatore. 
- [x] Eliminare un edizione di un torneo se si accede come organizzatore.
- [x] Visualizzare una classifica e delle statistiche in base a parametri in input.
- [ ] Possibilità da parte dei giocatori di commentare le partite
- [ ] Prenotazione delle lezioni
## How to run
* Per prima cosa occorre avere installato mySQL attraverso l'installer al link: https://dev.mysql.com/downloads/installer/
* Dopodichè occorre installare uno strumento visuale di progettazione per database ad esempio MySQL Workbench a questo link https://dev.mysql.com/downloads/workbench/
* Fatto questo si può procedere alla creazione del database e delle tabelle attraverso il file "create.sql" che trovate nella repo
* All'interno di WindowsFormApp, nel file "App.config", inserire la connection string adeguata
* Eseguire il programma
