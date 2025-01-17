﻿//Цикл обновления
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading.Channels;

namespace CSharpLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Behaviour[] behaviours =
            {
                new Walker(),
                new Jumper()
            };
            while (true)
            {
                foreach (var behaviour in behaviours)
                {
                    behaviour.Update();
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
    }

    class Behaviour
    {
        public virtual void Update()
        {

        }
    }
    class Walker : Behaviour
    {
        public override void Update()
        {
            Console.WriteLine("Иду");
        }
    }
    class Jumper : Behaviour
    {
        public override void Update()
        {
            Console.WriteLine("Прыгаю");
        }
    }


}