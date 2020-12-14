using S = System;

namespace CryptoCheck.Ex
{
    public class SystemIO
    {
        public SystemIODirectory Directory { get; private set; } = new SystemIODirectory();

        public SystemIOFile File { get; private set; } = new SystemIOFile();
    }
}
