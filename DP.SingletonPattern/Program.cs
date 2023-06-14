using System;

namespace DP.SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer loadBalancer1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer loadBalancer2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer loadBalancer3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer loadBalancer4 = LoadBalancer.GetLoadBalancer();

            if (loadBalancer1 == loadBalancer2 && loadBalancer2 == loadBalancer3 && loadBalancer3 == loadBalancer4)
            {
                Console.WriteLine("All instances are same.");
            }

            Console.ReadLine();
        }
    }    
}
