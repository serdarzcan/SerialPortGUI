using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialportgui
{
    public class SavedSettings
    {
        public int baudRate;
        public int dataBits;
        public int discardNull;
        public int dtrEnable;
        public int handshake;
        public int parity;
        public int parityReplace;
        public int readBufferSize;
        public int readTimeout;
        public int receivedBytesThr;
        public int rtsEnable;
        public int stopBits;

        public SavedSettings()
        {
            baudRate = 9600;
            dataBits = 8;
            discardNull = 1;
            dtrEnable = 1;
            handshake = 0;
            parity = 0;
            parityReplace = 63;
            readBufferSize = 4096;
            readTimeout = -1;
            receivedBytesThr = 1;
            rtsEnable = 1;
            stopBits = 1;
        }
    }
}
