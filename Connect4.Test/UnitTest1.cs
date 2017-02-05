using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Connect4;

namespace Connect4.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HorizCanWin()
        {
            //Arrange
            Game g = new Game();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    g.setup();
                    g.game[i, j] = 1;
                    g.game[i, j + 1] = 1;
                    g.game[i, j + 2] = 1;
                    g.game[i, j + 3] = 1;
                    //Act
                    bool value = g.checkwin();
                    //Assert
                    Assert.AreEqual(true, value);
                }
            }
        }

        [TestMethod]
        public void VertCanWin()
        {
            //Arrange
            Game g = new Game();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    g.setup();
                    g.game[i, j] = 1;
                    g.game[i + 1, j] = 1;
                    g.game[i + 2, j] = 1;
                    g.game[i + 3, j] = 1;
                    //Act
                    bool value = g.checkwin();
                    //Assert
                    Assert.AreEqual(true, value);
                }
            }
        }

        [TestMethod]
        public void DiagCanWin()
        {
            //Arrange
            Game g = new Game();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    g.setup();
                    g.game[i, j] = 1;
                    g.game[i + 1, j + 1] = 1;
                    g.game[i + 2, j + 2] = 1;
                    g.game[i + 3, j + 3] = 1;
                    //Act
                    bool value = g.checkwin();
                    //Assert
                    Assert.AreEqual(true, value);
                }
            }
        }

        [TestMethod]
        public void OtherDiagCanWin()
        {
            //Arrange
            Game g = new Game();

            for (int i = 5; i > 2; i--)
            {
                for (int j = 0; j < 4; j++)
                {
                    g.setup();
                    g.game[i, j] = 1;
                    g.game[i - 1, j + 1] = 1;
                    g.game[i - 2, j + 2] = 1;
                    g.game[i - 3, j + 3] = 1;
                    //Act
                    bool value = g.checkwin();
                    //Assert
                    Assert.AreEqual(true, value);
                }
            }
        }
    }
}
