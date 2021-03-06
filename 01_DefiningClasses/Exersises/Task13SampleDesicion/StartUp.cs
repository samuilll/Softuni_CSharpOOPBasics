﻿using System;


    class StartUp
    {
        static void Main(string[] args)
        {
            string mainPersonInput = Console.ReadLine();
            FamilyTreeBuilder familyTreeBuilder = new FamilyTreeBuilder(mainPersonInput);

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                ParseInput(input, familyTreeBuilder);
            }

            string familyTree = familyTreeBuilder.Build();
            Console.WriteLine(familyTree);
        }
    private static void ParseInput(string input, FamilyTreeBuilder familyTreeBuilder)
    {
        string[] tokens = input.Split(" - ");
        if (tokens.Length > 1)
        {
            ParentChild(familyTreeBuilder, tokens);
        }
        else
        {
            FullInfo(familyTreeBuilder, tokens);
        }
    }

    private static void FullInfo(FamilyTreeBuilder familyTreeBuilder, string[] tokens)
    {
        tokens = tokens[0].Split();
        string name = $"{tokens[0]} {tokens[1]}";
        string birthday = tokens[2];

        familyTreeBuilder.SetFullInfo(name, birthday);
    }

    private static void ParentChild(FamilyTreeBuilder familyTreeBuilder, string[] tokens)
    {
        string parentInput = tokens[0];
        string childInput = tokens[1];
        familyTreeBuilder.SetParentChildRelation(parentInput, childInput);
    }
}

