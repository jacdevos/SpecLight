﻿using System;
using Xunit;

namespace SpecLight.Tests
{
    public class StringHelpersTests
    {
        [Fact]
        public void ValuesAreOneWord()
        {
            Assert.Equal("the US is one word", StringHelpers.CreateText(((Action<string>) The_IsOneWord).Method, "US"));
        }

        [Fact]
        public void ShouldTrueGetsReplaced()
        {
            Assert.Equal("shan't", StringHelpers.CreateText(((Action<bool>) Shall_).Method, false));
            Assert.Equal("I shouldn't see the light", StringHelpers.CreateText(((Action<bool>) IShould_SeeTheLight).Method, false));
        }

        [Fact]
        public void ParameterNameGetsUsed()
        {
	        Assert.Equal("the thing passes", StringHelpers.CreateText(((Action<bool>) TheThing_).Method, true));
	        Assert.Equal("the thing fails really badly", StringHelpers.CreateText(((Action<bool>) TheThing_).Method, false));
        }

	    void The_IsOneWord(string s)
	    {
	    }

	    private void Shall_(bool b)
	    {
	    }

	    private void IShould_SeeTheLight(bool b)
	    {
	    }

	    private void TheThing_(bool passesOrFailsReallyBadly)
	    {
	    }
    }
}