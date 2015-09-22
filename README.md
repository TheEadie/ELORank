[![Build status](https://ci.appveyor.com/api/projects/status/ilqrc64go61cilog/branch/master?svg=true)](https://ci.appveyor.com/project/TheEadie/playerrank/branch/master)

# PlayerRank
Calculates Rankings for multiplayer games

### How to install

Run the following command in Nuget Package Manager Console: `Install-Package PlayerRank`

### Basic usage

```
var game = new Game();
game.AddResult("Foo", new Points(10));
game.AddResult("Bar", new Points(0));

var league = new League();
league.RecordGame(game);

var scoringStrategy = new SimpleScoringStrategy();

foreach (var position in league.GetLeaderBoard(scoringStrategy))
{
    Console.WriteLine("Position: {0}, Name: {1}, Score: {2}", position.Position, position.Name, position.Points);
}
```
