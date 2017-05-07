using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Debaters.Models;
using FluentAssertions;

namespace Debaters.Tests
{
    [TestClass]
    public class JayTests
    {
        [TestMethod]
        public void JayShouldHaveNameJayWhenCreated()
        {
            var jay = new Jay();
            jay.Name.Should().Be("Jay", "Jay should have name equals to Jay, when created");
        }
        [TestMethod]
        public void JaysFetchNewNumberIncreasesScoreWhenReceives2()
        {
            var jay = new Jay();
            jay.FetchNewNumber(jay, new NewNumbertronNumberArgs { Number = 4 });
            jay.Score.Should().Be(1, "receiving even number increases Jay's score");
        }
        [TestMethod]
        public void JaysFetchNewNumberIncreasesScoreWhenReceivesAnyEvenNumberMultipleTimes()
        {
            var jay = new Jay();
            jay.FetchNewNumber(jay, new NewNumbertronNumberArgs { Number = 42 });
            jay.FetchNewNumber(jay, new NewNumbertronNumberArgs { Number = 22 });
            jay.Score.Should().Be(2, "receiving even number increases Jay's score");
        }
        [TestMethod]
        public void JaysFetchNewNumberShouldNotIncreaseScoreWhenReceivingOddNumber()
        {
            var jay = new Jay();
            jay.FetchNewNumber(new object(), new NewNumbertronNumberArgs { Number = 7 });
            jay.Score.Should().Be(0, "receiving odd number should not increase Jay's score");
        }
    }
}
