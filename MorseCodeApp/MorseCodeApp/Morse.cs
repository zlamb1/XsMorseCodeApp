﻿using System;
namespace AwsomeApp
{
    public class Morse
    {
        private static string[] codes = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "" };

        private static char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' '};
        public Morse()
        {


        }
        public static char MorseCoder(string code) {
            char result='?';
            for (int i = 0; i < codes.Length;i++) {
                if (codes[i].Equals(code)) {
                    result = letters[i];
                    break;
                }
            }
            return result;
        }
    }
}
