using CSharpFunctionalExtensions;
using TicTacToe.Boards;

namespace TicTacToe.Players;

public class RandomPlayer : Player
{
    public override char Icon { get; }

    public RandomPlayer(char icon)
    {
        this.Icon = icon;
    }

    public override Result<PlayerMove> GetNextMove()
        => PlayerMove.Random;

}