using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    partial class Practice
    {
        public static Random random = new Random();


        /// <summary>
        /// BL8-P1/3. Cоздать структуру 2DRectangle, которая будет содержать ширину, высоту и координату.
        /// </summary>
        public static void Lb8_P1_3()
        {
            Rectangle struct1 = new Rectangle(random.Next(10), random.Next(10), random.Next(10), random.Next(10));
            Console.WriteLine($"{struct1.width},{struct1.height},{struct1.x},{struct1.y},");
        }
        public struct Rectangle 
        {
            public double width;
            public double height;
            public int x;
            public int y;
            public Rectangle(int width, int height, int x, int y)
            {
                this.width = width;
                this.height = height;
                this.x = x;
                this.y = y;
            }

        }

       

        /// <summary>
        /// BL8-P2/3. Cоздать случайный массив квадратов с количеством элементов 100. 
        /// Используйте класс Random(10), чтоб установить значения сторон. 
        /// </summary>
        //public static void Lb8_P2_3()
        //{
        //    Square[] mass1 = new Square[99];
        //    for (int i = 0; i<99;i++)
        //    {
        //            mass1[i].a = random.Next(1,10);
        //    }
        //    for (int i = 0; i < 99; i++)
        //    {
        //        Console.WriteLine(mass1[i]);
        //    }
        //}

        //public struct Square
        //{
        //    public double a;

        //    public Square(double a)
        //    {
        //        this.a = a;
        //    }
        //}
        /// <summary>
        /// BL8-P3/3.Anonymous. Создать метод GetSongData, 
        /// который принимает обьекта типа Song и возвращает анонимный тип, 
        /// который содержит Title, Minutes, Seconds и AlbumYear. 
        /// </summary>
        public static void Lb8_P3_3_Anonymous()
        {            
        }
    }
    
}
