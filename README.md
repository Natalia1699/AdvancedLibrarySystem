Advanced Library System - Projekt Programowania Obiektowego

Opis Projektu
Advanced Library System to prosty system zarządzania biblioteką napisany w języku C# z wykorzystaniem platformy .NET.
Projekt został przygotowany w celu zaprezentowania najważniejszych mechanizmów programowania obiektowego
oraz wybranych zaawansowanych funkcjonalności języka C#.
Program umożliwia:
•	dodawanie elementów do biblioteki, 
•	wypożyczanie książek użytkownikom, 
•	zwracanie książek, 
•	prezentację działania polimorfizmu, 
•	obsługę zdarzeń, 
•	wykorzystanie refleksji, 
•	wykonywanie operacji asynchronicznych. 

Technologie
Projekt został wykonany z wykorzystaniem:
•	C# 
•	.NET 
•	xUnit 

Struktura Projektu
AdvancedLibrarySystem
│
├── Models
├── Core
├── Interfaces
├── AdvancedLibrarySystem.Tests
└── Program.cs

Folder Models
Folder zawiera klasy reprezentujące elementy biblioteki, między innymi:
•	LibraryItem 
•	Book 
•	EBook 
•	AudioBook 
•	User 

Folder Core
Folder zawiera logikę działania systemu:
•	Repository 
•	LibraryService 

Folder Interfaces
Folder zawiera interfejsy definiujące zachowania obiektów.
Przykład:
•	IBorrowable 

Folder AdvancedLibrarySystem.Tests
Folder zawiera testy jednostkowe napisane przy użyciu frameworka xUnit.

Plik Program.cs
Plik odpowiedzialny za uruchomienie programu oraz demonstrację działania aplikacji.

Programowanie Obiektowe w Projekcie
Klasa Abstrakcyjna
Podstawową klasą systemu jest abstrakcyjna klasa: LibraryItem
Klasa zawiera wspólne właściwości wszystkich elementów biblioteki:
•	Title 
•	Author 
•	Year 
Dodatkowo klasa posiada statyczne pole: ItemCount
które zlicza wszystkie utworzone obiekty.
W projekcie wykorzystano:
•	klasy abstrakcyjne, 
•	konstruktory, 
•	właściwości, 
•	pola statyczne. 

Dziedziczenie i Polimorfizm
Klasy:
•	Book 
•	EBook 
•	AudioBook 
dziedziczą po klasie LibraryItem.
Każda z klas implementuje metodę: GetDescription()
Dzięki temu ta sama metoda działa inaczej dla różnych typów obiektów, co stanowi przykład polimorfizmu.
W projekcie wykorzystano:
•	dziedziczenie, 
•	polimorfizm, 
•	przesłanianie metod. 

Interfejsy
W projekcie zastosowano interfejs: IBorrowable
Interfejs definiuje możliwość wypożyczania elementów biblioteki i zawiera metody:
Borrow()
Return()
Klasa Book implementuje ten interfejs, dzięki czemu książki mogą być wypożyczane użytkownikom.

Kolekcje Generyczne
Elementy biblioteki są przechowywane w repozytorium: Repository<T>
Repozytorium wykorzystuje kolekcję: List<T>
Zastosowanie typów generycznych umożliwia przechowywanie różnych typów obiektów.
W projekcie wykorzystano:
•	kolekcje generyczne, 
•	typy ogólne, 
•	listy. 

Zdarzenia i Programowanie Asynchroniczne
Klasa: LibraryService
odpowiada za zarządzanie biblioteką.
Zawiera zdarzenia:
ItemAdded
ItemBorrowed
które informują system o dodaniu lub wypożyczeniu elementu.
Dodawanie elementów zostało zaimplementowane jako metoda asynchroniczna:
AddItemAsync()
z wykorzystaniem słów kluczowych:
async
await
W projekcie wykorzystano:
•	zdarzenia, 
•	delegaty, 
•	programowanie asynchroniczne. 

Przeciążanie Operatorów
W klasie Book przeciążono operator: operator +
Operator umożliwia połączenie dwóch książek w jeden nowy obiekt.
Przykład:
Book combinedBook = book1 + book2;

Refleksja
Projekt wykorzystuje refleksję do odczytywania metod klasy Book podczas działania programu.
W pliku Program.cs użyto: typeof(Book).GetMethods()
Mechanizm ten umożliwia analizę typów oraz metod w czasie wykonywania aplikacji.

Testy Jednostkowe
Projekt zawiera testy jednostkowe napisane przy użyciu frameworka xUnit.
Przykładowe testy:
AddItem_ShouldIncreaseRepositoryCount
BorrowItem_ShouldAssignUser
BorrowItem_Twice_ShouldThrowException
OperatorPlus_ShouldCombineTitles
AddItem_ShouldTriggerEvent
Testy sprawdzają:
•	poprawność dodawania elementów, 
•	działanie wypożyczania, 
•	obsługę wyjątków, 
•	działanie przeciążonego operatora, 
•	poprawność działania zdarzeń. 

Uruchomienie Projektu
Wymagania
Do uruchomienia projektu wymagane są:
•	.NET SDK 
•	Visual Studio 2022 lub nowsze 

Uruchomienie aplikacji
dotnet restore
dotnet build
dotnet run

Uruchomienie testów
dotnet test

Demonstracja Działania Programu
Program demonstruje:
•	dodawanie książek, 
•	wypożyczanie i zwracanie książek, 
•	działanie polimorfizmu, 
•	działanie zdarzeń, 
•	refleksję, 
•	działanie metod asynchronicznych. 
W konsoli wyświetlane są informacje dotyczące działania systemu biblioteki.

Podsumowanie
Projekt demonstruje wykorzystanie najważniejszych mechanizmów programowania obiektowego w języku C#, takich jak:
•	dziedziczenie, 
•	polimorfizm, 
•	interfejsy, 
•	klasy abstrakcyjne, 
•	kolekcje generyczne, 
•	zdarzenia, 
•	przeciążanie operatorów, 
•	programowanie asynchroniczne, 
•	refleksja. 
Dodatkowo projekt został przetestowany przy użyciu testów jednostkowych frameworka xUnit,
co pozwala zweryfikować poprawność działania aplikacji.
