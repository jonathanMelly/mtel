﻿using System;

namespace interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TODO gérer les options en ligne de commande
            Interpreter interpreter = new Interpreter(args[0]);
            interpreter.Execute();
        }
    }
}