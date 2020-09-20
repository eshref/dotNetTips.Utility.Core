﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Extensions.Tests
// Author           : David McCarter
// Created          : 05-07-2020
//
// Last Modified By : David McCarter
// Last Modified On : 07-22-2020
// ***********************************************************************
// <copyright file="StringExtensionsTests.cs" company="dotNetTips.Utility.Standard.Extensions.Tests">
//     Copyright (c) McCarter Consulting. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using dotNetTips.Utility.Standard.Tester;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace dotNetTips.Utility.Standard.Extensions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void ComputeMD5HashTest()
        {
            var testValue = RandomData.GenerateWord(10);

            Assert.IsTrue(string.IsNullOrEmpty(testValue.ComputeMD5Hash()) == false);
        }

        [TestMethod]
        public void ComputeSha256HashTest()
        {
            var testValue = RandomData.GenerateWord(10);

            Assert.IsTrue(string.IsNullOrEmpty(testValue.ComputeSha256Hash()) == false);
        }

        [TestMethod]
        public void ConcatTest()
        {
            var testValue1 = RandomData.GenerateWord(10);
            var testValue2 = RandomData.GenerateWord(15);

            Assert.IsTrue(string.IsNullOrEmpty(testValue1.Concat("-", false, testValue2)) == false);
            Assert.IsTrue(testValue1.Concat("-", false, testValue2).Length == 26);
        }

        [TestMethod]
        public void ContainsAnyTest()
        {
            var testValue = "dotNetTips.com";

            Assert.IsTrue(testValue.ContainsAny("d", "T"));
        }

        [TestMethod]
        public void DefaultIfNullOrEmptyTest()
        {
            string testValue = null;

            Assert.IsTrue(testValue.DefaultIfNullOrEmpty(RandomData.GenerateWord(5)).Length == 5);
        }

        [TestMethod]
        public void DefaultIfNullTest()
        {
            string testValue = null;

            Assert.IsTrue(testValue.DefaultIfNull().Length == 0);

            Assert.IsTrue(testValue.DefaultIfNull(RandomData.GenerateWord(5)).Length == 5);
        }

        [TestMethod]
        public void EqualsIgnoreCaseTest()
        {
            var testValue = RandomData.GenerateWord(10);

            Assert.IsTrue(testValue.EqualsIgnoreCase(testValue));
        }

        [TestMethod]
        public void EqualsOrBothNullOrEmptyTest()
        {
            var testValue = RandomData.GenerateWord(10);

            Assert.IsTrue(testValue.EqualsOrBothNullOrEmpty(testValue));

            Assert.IsTrue(string.Empty.EqualsOrBothNullOrEmpty(null));
        }

        [TestMethod]
        public void HasValueTest()
        {
            var testValue = RandomData.GenerateWord(10);

            Assert.IsTrue(testValue.HasValue());

            Assert.IsTrue(testValue.HasValue(10));

            Assert.IsFalse(testValue.HasValue("XXXXX"));
        }

        [TestMethod]
        public void DelimitedStringToArrayTest()
        {
            var inputString = "Microsoft .NET, Visual Studio, Azure";

            var result = inputString.DelimitedStringToArray();

            Assert.IsTrue(result.Count() == 3);

        }
        [TestMethod]
        public void HasWhiteSpaceTest()
        {
            var testWithText = RandomData.GenerateWord(10);
            var testWithWhitespace = "      ";

            Assert.IsFalse(testWithText.IsWhitespace());
            Assert.IsTrue(testWithWhitespace.IsWhitespace());
            Assert.IsTrue(' '.IsWhitespace());
            Assert.IsFalse('d'.IsWhitespace());
        }

        [TestMethod]
        public void IndentTest()
        {
            var testValue = RandomData.GenerateWord(100);

            var result = testValue.Indent(2, '>');

            Assert.IsTrue(result.Length > 100);
        }

        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsFalse(RandomData.GenerateWord(10).IsEmpty());

            Assert.IsTrue(string.Empty.IsEmpty());
        }

        [TestMethod]
        public void IsNotEmptyTest()
        {
            Assert.IsTrue(RandomData.GenerateWord(10).IsNotEmpty());

            Assert.IsFalse(string.Empty.IsNotEmpty());
        }

        [TestMethod]
        public void ReplaceEllipsisWithPeriodTest()
        {
            var testValue = RandomData.GenerateWord(25) + "...";

            var result = testValue.ReplaceEllipsisWithPeriod();

            Assert.IsTrue(result.EndsWith("...") == false);
        }

        [TestMethod]
        public void SplitTest()
        {
            var testValue = RandomData.GenerateWord(25) + ',' + RandomData.GenerateWord(25);

            Assert.IsTrue(testValue.Split(',').Count() == 2);
        }

        [TestMethod]
        public void SplitWithCharAndCountTest()
        {
            var testValue = $"coding, programming, microsoft";

            var result = testValue.Split(',', 2, System.StringSplitOptions.RemoveEmptyEntries);

            Assert.IsTrue(result.Count() == 2);

            result = testValue.Split(',', 1, System.StringSplitOptions.None);

            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void SplitWithCharTest()
        {
            var testValue = $"coding, programming, microsoft";

            var result = testValue.Split(',', System.StringSplitOptions.RemoveEmptyEntries);

            Assert.IsTrue(result.Count() == 3);

            result = testValue.Split(',', System.StringSplitOptions.None);

            Assert.IsTrue(result.Count() == 3);
        }

        [TestMethod]
        public void SplitWithStringAndCountTest()
        {
            var testValue = $"coding, programming, microsoft";

            var result = testValue.Split(",", 2, System.StringSplitOptions.RemoveEmptyEntries);

            Assert.IsTrue(result.Count() == 2);

            result = testValue.Split(",", 1, System.StringSplitOptions.None);

            Assert.IsTrue(result.Count() == 1);
        }

        [TestMethod]
        public void SplitWithStringTest()
        {
            var testValue = $"coding, programming, microsoft";

            var result = testValue.Split(",", System.StringSplitOptions.RemoveEmptyEntries);

            Assert.IsTrue(result.Count() == 3);

            result = testValue.Split(",", System.StringSplitOptions.None);

            Assert.IsTrue(result.Count() == 3);
        }

        [TestMethod]
        public void StartsWithOrdinalIgnoreCaseTest()
        {
            var testValue = RandomData.GenerateWord(10);

            Assert.IsTrue(testValue.StartsWithOrdinalIgnoreCase(testValue));
        }

        [TestMethod]
        public void StartsWithOrdinalTest()
        {
            var testValue = RandomData.GenerateWord(10);

            Assert.IsTrue(testValue.StartsWithOrdinal(testValue));
        }

        [TestMethod]
        public void SubstringTrimTest()
        {
            var testValue = RandomData.GenerateWord(50);

            //Test Params
            Assert.ThrowsException<ArgumentNullException>(() => string.Empty.SubstringTrim(1, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.SubstringTrim(-100, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.SubstringTrim(1, -10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => testValue.SubstringTrim(1, 100));

            //Test
            Assert.IsTrue(testValue.SubstringTrim(1, 10).HasValue());
        }

        [TestMethod]
        public void TrimTest()
        {
            var testValue = RandomData.GenerateWord(25) + "   ";

            Assert.IsTrue(testValue.ToTrimmed().Length == 25);
        }
    }
}
