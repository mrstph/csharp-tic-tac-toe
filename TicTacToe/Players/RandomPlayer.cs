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

    public override async Task<Result<PlayerMove>> GetNextMoveAsync()
    {
        Console.Write($"IA {Icon} is thinking");

        for (var i = 1; i < 4; i++)
        {
            await Task.Delay(700);
            Console.Write(".");
        }

        return await Task.FromResult(GetNextMove());
    }
}