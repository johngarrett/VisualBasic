using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    class Dog: Animal 
      

    {
        public string name;
        public string breed;
        public Dog (string _name)
        { 
            name = _name; }
        public void WhatAreYou()
        {
            Console.WriteLine("I am a dog");
        }
        
    }
    
}

