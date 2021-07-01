using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void UnBalancedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]"));
        }

        [TestMethod]
        public void NonBracketCharIgnored()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[i[i]]"));
        }

        [TestMethod]
        public void IncorrectBracketOrderFails()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void TooManyCloseBracketsFails()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]]]]]["));
        }

        [TestMethod]
        public void IncorrectNumBracketsEndingWithCloseFails()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[][]]"));
        }

        [TestMethod]
        public void NestedBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[][]]"));
        }

        [TestMethod]
        public void BalancedOutOfORderFails()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("][][][][]"));
        }
    }
}
