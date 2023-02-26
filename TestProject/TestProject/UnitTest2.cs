using BusinessLayer;
using FluentAssertions;
using Xunit;

namespace TestProject
{
    public static class UnitTest2
    {
        [Fact]
        public static void TestThrowMethod()
        {
            Testable testable = new Testable();

            Action? action = () => testable.MethotThatThrowsExeption(6);

            testable.Invoking(x => action).Should().Throw<ArgumentNullException>();

            action.Should().Throw<ArgumentNullException>().WithMessage("?rror_message");

            action.Should().Throw<ArgumentNullException>().Where(e => e.Message.Contains("error"));
        }

        [Fact]
        public static void TestNotThrowMethod()
        {
            Testable testable = new Testable();

            Action? action = () => testable.MethotThatThrowsExeption(6);

            testable.Invoking(x => action).Should().NotThrow();
            testable.Invoking(x => action).Should().NotThrow<NotImplementedException>();
        }
    }
}
