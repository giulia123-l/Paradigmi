Progetto Paradigmi di Programmazione

Questo repository contiene un progetto sviluppato nell'ambito dell'esame di Paradigmi di Programmazione presso l'Università di Camerino. Il progetto implementa una Web API per la gestione di un catalogo librario utilizzando tecnologie come ASP.NET Core e Entity Framework Core.

La Web API offre le seguenti funzionalità:

Gestione utenti:

- Registrazione di un nuovo utente (non richiede autenticazione iniziale).

- Autenticazione tramite credenziali utente (login).

Gestione categorie:

- Creazione di nuove categorie (non possono esistere due categorie con lo stesso nome).

- Eliminazione di categorie esistenti (solo se non contengono libri associati).

Gestione libri:

- Inserimento di nuovi libri nel catalogo.

- Modifica delle informazioni relative a un libro esistente.

- Eliminazione di un libro dal catalogo.

Ricerca avanzata di libri:

- Ricerca per categoria.

- Ricerca per titolo.

- Ricerca per data di pubblicazione.

- Ricerca per autore.

- Requisiti per l'avvio del progetto

Per avviare il progetto, seguire i passaggi elencati di seguito.

1. Preparazione dell'ambiente

Assicurarsi di avere installato .NET Core SDK e un database compatibile (es. SQL Server).

2. Ripristino del database

Ripristinare il database utilizzando il file di dump incluso nel repository.

3. Configurazione del file appsettings.json

Aprire il file appsettings.json all'interno del progetto Paradigmi.Library.Web.

Modificare la stringa di connessione al database in base alla propria configurazione locale.

4. Avvio dell'applicazione

Eseguire il progetto utilizzando un IDE compatibile con .NET (es. Visual Studio, Rider) o da terminale con il comando:
dotnet run

Utilizzo dell'API

1. Registrazione

Registrare un nuovo utente tramite l'apposito endpoint. Non è necessaria l'autenticazione per questa operazione.

2. Login e ottenimento del token JWT

Effettuare il login utilizzando le credenziali appena create.

Al successo del login, l'API restituirà un token JWT.

3. Autenticazione

Utilizzare il token JWT ottenuto per accedere alle funzionalità protette dell'API.

Una volta autenticati, sarà possibile utilizzare tutte le funzionalità sopra descritte per la gestione di utenti, categorie e libri.

Tecnologie utilizzate

ASP.NET Core: Framework per la creazione di applicazioni web.

Entity Framework Core: ORM per la gestione del database.

JWT (JSON Web Token): Per l'autenticazione e la gestione delle sessioni utente.
