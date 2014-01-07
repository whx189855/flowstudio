﻿// Copyright (C) 2013 João Pedro Correia - All Rights Reserved
// Code under the terms of the GPLv2 license
// URL: http://flowstudio.codeplex.com

namespace FlowStudio.Presentation.ViewModel.Data
{
    using System;

    public class OutlineVariableItem : OutlineItem
	{
        public string Name { get; private set; }

        public Type Type { get; private set; }

        public OutlineVariableItem(string name, Type type)
        {
            Name = name;
            Type = type;
        }
	}
}