using System;
namespace firstxf.ViewModel
{
    public class RoundCookies
    {
        public int weight { get; set; }
        public string colour { get; set; }
        public bool icing { get; set; }

        public RoundCookies()
        {
            var result = Add(1, 2);

        }

        public void Decorate() { }
        public void Consume() { }

        private int Add(int a, int b)
        {
            var sum = a + b;
            return sum;
        }


    }
}
