namespace DP.SingletonPattern
{
    class LoadBalancer
    {
        private static LoadBalancer _instance { get; set; }
        private static object lockObject = new object();

        protected LoadBalancer() { }

        internal static LoadBalancer GetLoadBalancer()
        {
            if (_instance == null)
            {
                lock (lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }
    }
}
