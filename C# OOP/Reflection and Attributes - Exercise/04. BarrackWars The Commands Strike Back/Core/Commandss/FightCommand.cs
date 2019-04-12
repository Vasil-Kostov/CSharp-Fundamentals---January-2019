﻿namespace _03BarracksFactory.Core.Commandss
{
    using Contracts;
    using System;

    public class FightCommand : Command
    {
        private object environment;

        public FightCommand(string[] data, IRepository repository, IUnitFactory unitFactory) 
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
