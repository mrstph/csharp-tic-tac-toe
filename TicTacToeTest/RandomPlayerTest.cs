using CSharpFunctionalExtensions;
using FluentAssertions;
using TicTacToe.Boards;
using TicTacToe.Players;

namespace TicTacToeTest
{
    public class RandomPlayerTest
    {
        [Fact]
        public void ActualMove_Default_ReturnsValidMove()
        {
            RandomPlayer randomPlayer = new RandomPlayer(PlayerConstants.PlayerOneIcon);

            Result<PlayerMove> actualMove = randomPlayer.GetNextMove();

            actualMove.IsSuccess
                .Should()
                .BeTrue();

            actualMove.Value.Row
                .Should()
                .BeInRange(1, 3);

            actualMove.Value.Column
                .Should()
                .BeInRange(1, 3);
        }
    }
}
