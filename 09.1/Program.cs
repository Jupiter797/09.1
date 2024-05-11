using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._1
{
    class Property
    {
        private char charField;
        private int intField;

        public string textProperty
        {
            get
            {
                return $"Символ : {charField} | Значення : {intField}";
            }
        }

        public Property(char charField, int intField)
        {
            this.charField = charField;
            this.intField = intField;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Property property = new Property('A', 10);

            Console.WriteLine(property.textProperty);

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
