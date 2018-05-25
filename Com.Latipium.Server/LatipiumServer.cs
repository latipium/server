using System;
using Com.Latipium.Engine;

namespace Com.Latipium.Server {
    class LatipiumServer : ILatipiumServer {
        public static void Main(string[] args) {
            LatipiumEngine.Start(new LatipiumServer());
        }
    }
}
