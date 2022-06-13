﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab5.Models;
using System.Drawing;

namespace Lab5.Main
{
    class ViewModel : ViewObject
    {
        public Model Model { get; }

        public override float X { get => Model.posX; }
        public override float Y { get => Model.posY; }

        public ViewModel(Model model, Image image)
            : base(image)
        {
            this.Model = model;
        }
    }
}
