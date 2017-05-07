using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Debaters.Models;
using FluentAssertions;

namespace Debaters.Tests
{
    [TestClass]
    public class SilentBobTests
    {
        [TestMethod]
        public void BobShouldHaveNameSilentBobWhenCreated()
        {
            var bob = new SilentBob();
            bob.Name.Should().Be("Silent Bob", "SilentBob should have name equals to 'Silent Bob', when created");
        }
        [TestMethod]
        public void BobsFetchNewNumberIncreasesScoreWhenReceives2()
        {
            var bob = new SilentBob();
            bob.FetchNewNumber(this, new NewNumbertronNumberArgs { Number = 3 });
            bob.Score.Should().Be(1, "receiving odd number increases Bob's score");
        }
        [TestMethod]
        public void BobsFetchNewNumberIncreasesScoreWhenReceivesAnyOddNumberMultipleTimes()
        {
            var bob = new SilentBob();
            bob.FetchNewNumber(bob, new NewNumbertronNumberArgs { Number = 11 });
            bob.FetchNewNumber(bob, new NewNumbertronNumberArgs { Number = 1 });
            bob.Score.Should().Be(2, "receiving odd number increases Bob's score");
        }
        [TestMethod]
        public void BobsFetchNewNumberShouldNotIncreaseScoreWhenReceivingEvenNumber()
        {
            var bob = new SilentBob();
            bob.FetchNewNumber(new object(), new NewNumbertronNumberArgs { Number = 4 });
            bob.Score.Should().Be(0, "receiving even number should not increase bob's score");
        }
    }
}
