﻿using System;

namespace JsonApiDotNetCore.Extensions
{
  public static class StringExtensions
  {
    public static string ToCamelCase(this string str)
    {
      var splittedPhraseChars = str.ToCharArray();
      if (splittedPhraseChars.Length > 0)
      {
        splittedPhraseChars[0] = new string(splittedPhraseChars[0], 1).ToLower().ToCharArray()[0];
        return new String(splittedPhraseChars);
      }
      return str;
    }
    public static string ToProperCase(this string str)
    {
      var splittedPhraseChars = str.ToCharArray();
      if (splittedPhraseChars.Length > 0)
      {
        splittedPhraseChars[0] = new string(splittedPhraseChars[0], 1).ToUpper().ToCharArray()[0];
        return new String(splittedPhraseChars);
      }
      return str;
    }
  }
}
