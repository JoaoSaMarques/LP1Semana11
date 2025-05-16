# PlayerManagerMVC2

This project manages a list of players with their scores and supports sorting by score or name.

## UML Class Diagram

```mermaid
classDiagram
    class Player {
        - Name : string
        - Score : int
        + Player(name : string, score : int)
        + CompareTo(other : Player) int
        + ToString() string
    }

    class CompareByName {
        - ord : bool
        + CompareByName(ord : bool)
        + Compare(p1 : Player, p2 : Player) int
    }

    class PlayerOrder {
        + ByScore
        + ByName
        + ByNameReverse
    }

    class Program {
        - playerList : List
        - compareByName : IComparer
        - compareByNameReverse : IComparer
        + Main(args : string[])
        + Start() void
        + ShowMenu() void
        + InsertPlayer() void
        + ListPlayers(playersToList : Iterable) void
        + ListPlayersWithScoreGreaterThan() void
        + GetPlayersWithScoreGreaterThan(minScore : int) Iterable
        + SortPlayerList() void
    }

    CompareByName ..|> IComparer
    Program --> Player
    Program --> CompareByName
    Program --> PlayerOrder
