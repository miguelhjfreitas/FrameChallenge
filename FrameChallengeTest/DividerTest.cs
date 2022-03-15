using FrameChallenge.Models;
using FrameChallenge.Services;
using NUnit.Framework;

namespace FrameChallengeTest
{
    public class Tests
    {

        private IDividersService _dividerService;

        [SetUp]
        public void Setup()
        {
            _dividerService = new DividerService();
        }

        [Test]
        public void TestDividers()
        {
            int number = 1457361;
            NumberDivider numberDividerExpected = new NumberDivider(number);
            numberDividerExpected.Dividers.Add(1);
            numberDividerExpected.Dividers.Add(3);
            numberDividerExpected.Dividers.Add(9);
            numberDividerExpected.Dividers.Add(113);
            numberDividerExpected.Dividers.Add(339);
            numberDividerExpected.Dividers.Add(1017);
            numberDividerExpected.Dividers.Add(1433);
            numberDividerExpected.Dividers.Add(4299);
            numberDividerExpected.Dividers.Add(12897);
            numberDividerExpected.Dividers.Add(161929);
            numberDividerExpected.Dividers.Add(485787);
            numberDividerExpected.Dividers.Add(1457361);

            numberDividerExpected.PrimeDividers.Add(3);
            numberDividerExpected.PrimeDividers.Add(113);
            numberDividerExpected.PrimeDividers.Add(1433);

            NumberDivider numberDividerActual = _dividerService.GetDividers(number);

            Assert.That(numberDividerActual.Number, Is.EqualTo(numberDividerExpected.Number));
            Assert.That(numberDividerActual.Dividers, Is.EquivalentTo(numberDividerExpected.Dividers));
            Assert.That(numberDividerActual.PrimeDividers, Is.EquivalentTo(numberDividerExpected.PrimeDividers));
        }
    }
}