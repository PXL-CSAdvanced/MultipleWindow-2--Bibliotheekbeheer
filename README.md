# Bibliotheekbeheer Systeem - Opdracht
Ontwikkel een applicatie die de volgende functionaliteiten biedt:

### Boekenbeheer
- **Nieuw Boek Toevoegen:**  
  Maak een modaal venster (AddBookForm) waarin een nieuw boek kan worden toegevoegd.
Vereiste invoervelden zijn:
  - ISBN
  - Titel
  - Auteur
  Na validatie wordt een nieuw boek aangemaakt en toegevoegd aan de lijst in het hoofdvenster.

- **Boek Bewerken:**  
  Selecteer een boek uit de lijst en open een modaal venster (EditBookForm) waarin de gegevens (behalve het ISBN) aangepast kunnen worden.

- **Boek Verwijderen:**  
  Verwijder een geselecteerd boek uit de lijst, nadat de gebruiker een bevestigingsdialoog heeft gezien.

- **Uitlenen:**  
  Open een modaal venster (LendBookForm) waarin een gebruiker een lid selecteert uit een vooraf gedefinieerde lijst. Het geselecteerde boek wordt dan gemarkeerd als uitgeleend (IsAvailable = false) en de naam van het lid wordt opgeslagen.

- **Details Bekijken:**  
  Open een modeless venster (BookDetailsForm) dat de volledige details van een geselecteerd boek in read-only modus weergeeft. Dit venster kan open blijven tijdens andere bewerkingen.

### Communicatie tussen Vensters:
  Overdracht van data tussen vensters gebeurt via publieke properties in de modale vensters.

### Klassen

#### Book
- **Eigenschappen:**
  - `ISBN` (string)
  - `Title` (string)
  - `Author` (string)
  - `IsAvailable` (bool) – standaard `true`
  - `LoanedTo` (Member) – bevat het lid indien uitgeleend
- **Methode:**
  - `ToString()` – Retourneert een leesbare representatie van het boek, bijvoorbeeld:
    - `"1234567890 - De Avonturen van Tom (Auteur, 2001) - Beschikbaar"`
    - of `"1234567890 - De Avonturen van Tom (Auteur, 2001) - Uitgeleend aan Jan de Vries"`

#### Member
- **Eigenschappen:**
  - `MemberId` (string)
  - `Name` (string)
  - `Email` (string)
- **Methode:**
  - `ToString()` – Retourneert de naam van het lid voor gebruik in de ComboBox.

### Vensters

#### MainWindow
- **Functionaliteit:**
  - Toont een lijst met boeken (bijvoorbeeld in een ListBox of DataGrid).
  - Biedt knoppen voor:
    - **Nieuw Boek**: Opent het modale venster AddBookForm.
    - **Bewerk Boek**: Opent het modale venster EditBookForm.
    - **Verwijder Boek**: Verwijdert een geselecteerd boek na bevestiging.
    - **Uitlenen**: Opent het modale venster LendBookForm.
    - **Bekijk Details**: Opent het modeless venster BookDetailsForm.
  
#### AddBookForm
- **Doel:**  
  Laat de gebruiker een nieuw boek invoeren.
- **Invoer:**  
  - ISBN, Titel, Auteur.
- **Data-overdracht:**  
  - Na succesvolle validatie wordt het nieuwe boek opgeslagen in een publieke property (`NewBook`), waarna het venster met `DialogResult` wordt gesloten.

#### EditBookForm
- **Doel:**  
  Laat de gebruiker een geselecteerd boek bewerken.
- **Functionaliteit:**  
  - Het ISBN is niet aanpasbaar.
  - Wijzigingen worden direct toegepast op het geselecteerde boek.

#### LendBookForm
- **Doel:**  
  Laat de gebruiker een lid selecteren aan wie een boek wordt uitgeleend.
- **Invoer:**  
  - Een ComboBox met vooraf gedefinieerde leden.
- **Data-overdracht:**  
  - Het geselecteerde lid wordt opgeslagen in een publieke property (`SelectedMember`).

#### BookDetailsForm
- **Doel:**  
  Toont de volledige details van een geselecteerd boek in een modeless venster.
- **Functionaliteit:**  
  - Alle gegevens worden in read-only modus getoond.
  - Dit venster kan open blijven tijdens andere bewerkingen.

## Extra Uitdagingen (optioneel)
- Implementeer een zoekfunctie om boeken te filteren op titel, auteur of ISBN.
- Zorg voor extra validatie en foutafhandeling bij de gebruikersinvoer.
