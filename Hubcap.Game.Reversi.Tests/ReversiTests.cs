﻿using System;
using NUnit.Framework;

namespace Hubcap.Game.Reversi.Tests
{
    [TestFixture]
    public class ReversiTests
    {
        [Test]
        public void Placing_disc_on_occupied_space_should_throw()
        {
            //Arrange
            var board = Reversi.GetInitialState();

            //Act
            void newBoard() => Reversi.Move(board, 3, 3, 'X');

            //Assert
            Assert.Throws<InvalidOperationException>(newBoard);
        }

        [Test]
        public void Placing_X_on_24_on_initial_board_should_return_a_board()
        {
            //Arrange
            var board = Reversi.GetInitialState();

            //Act
            var newBoard = Reversi.Move(board, 2, 4, 'X');

            //Assert
        }

        [Test]
        public void Placing_X_on_23_on_initial_board_should_throw()
        {
            //Arrange
            var board = Reversi.GetInitialState();

            //Act
            void newBoard() => Reversi.Move(board, 2, 3, 'X');

            //Assert
            Assert.Throws<InvalidOperationException>(newBoard);
        }

        [Test]
        public void Placing_X_on_00_on_initial_board_should_throw()
        {
            //Arrange
            var board = Reversi.GetInitialState();

            //Act
            void newBoard() => Reversi.Move(board, 0, 0, 'X');

            //Assert
            Assert.Throws<InvalidOperationException>(newBoard);
        }

        [Test]
        public void Placing_X_on_77_on_initial_board_should_throw()
        {
            //Arrange
            var board = Reversi.GetInitialState();

            //Act
            void newBoard() => Reversi.Move(board, 7, 7, 'X');

            //Assert
            Assert.Throws<InvalidOperationException>(newBoard);
        }

        [Test]
        public void Placing_X_on_53_on_initial_board_should_return_a_board()
        {
            //Arrange
            var board = Reversi.GetInitialState();

            //Act
            var newBoard = Reversi.Move(board, 5, 3, 'X');

            //Assert
        }

        [Test]
        public void Placing_X_on_54_on_initial_board_should_throw()
        {
            //Arrange
            var board = Reversi.GetInitialState();

            //Act
            void newBoard() => Reversi.Move(board, 5, 4, 'X');

            //Assert
            Assert.Throws<InvalidOperationException>(newBoard);
        }
    }
}