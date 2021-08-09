using System;

namespace canasoft_ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = new CanasoftEcom();
            var token = cs.GetToken();
            Console.WriteLine(token.access_token);
            Console.WriteLine(token.token_type);
            Console.WriteLine("Hello World!");            
        }


    }
}
