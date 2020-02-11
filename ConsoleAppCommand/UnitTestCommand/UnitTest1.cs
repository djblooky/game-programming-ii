using ConsoleAppCommand;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCommand
{
    [TestClass]
    public class UnitTestCommand
    {
        GameComponent fakeGameComponent;

        public UnitTestCommand()
        {
            fakeGameComponent = new GameComponent();
        }

        [TestMethod]
        public void TestCommandMoveUp()
        {
            //arrange
            int originalYLocation = fakeGameComponent.Y;
            Command moveUp = new MoveUpCommand();
            int finalLocationY;
            int expectedMoveAmount = 1;

            //act
            moveUp.Execute(fakeGameComponent);
            finalLocationY = fakeGameComponent.Y;

            //assert
            Assert.AreEqual(originalYLocation, finalLocationY + expectedMoveAmount);
        }

        [TestMethod]
        public void TestCommandMoveRight()
        {
            //arrange
            int originalYLocation = fakeGameComponent.Y;
            Command moveRight = new MoveRightCommand();
            int finalLocationY;
            int expectedMoveAmount = 1;

            //act
            moveRight.Execute(fakeGameComponent);
            finalLocationY = fakeGameComponent.Y;

            //assert
            Assert.AreEqual(originalYLocation, finalLocationY + expectedMoveAmount);
        }
    }
}
