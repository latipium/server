using System;
using Com.Latipium.Engine;
using Com.Latipium.Engine.Data;

namespace Com.Latipium.Server {
    class LatipiumServer : ILatipiumServer {
        public Context OpenDatabaseContext() {
            return new Context();
        }

        public static void Main(string[] args) {
            LatipiumEngine.Start(new LatipiumServer());
        }
    }
}
