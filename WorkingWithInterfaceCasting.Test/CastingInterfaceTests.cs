namespace WorkingWithInterfaceCasting.Test
{
    using NUnit.Framework;
    using Moq;

    [TestFixture]
    public class CastingInterfaceTests
    {
        private Mock<IParentInterface> _parentMock;

        [SetUp]
        public void Setup()
        {
            _parentMock = new Mock<IParentInterface>();
        }

        [Test]
        public void DoWork_VerifyParentWorkAndChildWorkCalls_Test()
        {
            // Arrange
            _parentMock.Setup(m => m.ParentWork()).Verifiable();
            _parentMock.As<IChildInterface>().Setup(m => m.ChildWork()).Verifiable();
            var implementor = new Implementor(_parentMock.Object);

            // Act
            implementor.DoWork();

            // Assert
            _parentMock.Verify(m => m.ParentWork(), Times.Once());
            _parentMock.As<IChildInterface>().Verify(m => m.ChildWork(), Times.Once());
        }
    }
}
