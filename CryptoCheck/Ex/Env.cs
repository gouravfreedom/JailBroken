using S=System;
using CryptoCheck.Ex;

namespace CryptoCheck.Ex
{
    public class Env
    {
        public System System { get; private set; } = new System();

        public Reporter Reporter { get; set; } = new Reporter();
    }
}
