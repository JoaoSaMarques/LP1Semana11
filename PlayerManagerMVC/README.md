# PlayerManagerMVC

This project manages a list of players with their scores and supports sorting by score or name.

## UML Class Diagram

```mermaid
classDiagram
    class Player {
        - string Name
        - int Score
        + Player(string name, int score)
        + int CompareTo(Player other)
        + string ToString()
    }

    class CompareByName {
        - bool ord
        + CompareByName(bool ord)
        + int Compare(Player p1, Player p2)
    }

    enum PlayerOrder {
        ByScore = 1
        ByName = 2
        ByNameReverse = 3
    }

    class Program {
        - List~Player~ playerList
        - IComparer~Player~ compareByName
        - IComparer~Player~ compareByNameReverse
        + Main(string[] args)
        + void Start()
        + void ShowMenu()
        + void InsertPlayer()
        + static void ListPlayers(IEnumerable~Player~ playersToList)
        + void ListPlayersWithScoreGreaterThan()
        + IEnumerable~Player~ GetPlayersWithScoreGreaterThan(int minScore)
        + void SortPlayerList()
    }

    Player <|.. CompareByName : implements IComparer<Player>
    Program --> Player
    Program --> CompareByName
    Program --> PlayerOrder
