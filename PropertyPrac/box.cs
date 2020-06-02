using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPrac
{
    class box
    {
        const int DEFAULT_VALLUE = 10;
        public int width;
        public int height;

        private int IsPostiveNumber(int values)
        {
            if (values > 0 )
            {
                return values;
            }
            else
            {
                return DEFAULT_VALLUE;
                Console.WriteLine("잘못된 값이 들어옴");
            }
        }


        public box(int width, int height)
        {
            this.width = IsPostiveNumber(width);
            this.height = IsPostiveNumber(height);
        }

        public int Area()
        {
            return width * height;
        }

        public int GetWidth() { return width; } 

        public void SetWidth(int width) 
        {
            this.width = IsPostiveNumber(width);
        }

        public int GetHeight() { return height; }

        public void SetHeight(int height) 
        {
            this.height = IsPostiveNumber(height);

        }
    }
}
