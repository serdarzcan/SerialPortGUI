using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialportgui
{
    class DataPack
    {
        public string type;
        public int size;
        public string data;
        public string prevData;

        public DataPack()
        {
            this.type = null;
            this.size = 0;
            //this.tag = null;
            this.data = null;
            this.prevData = null;
        }

        public DataPack(string type, int size, /*String tag, */string data, string prevData)
        {
            this.type = type;
            this.size = 0;
            //this.tag = tag;
            this.data = data;
            this.prevData = prevData;
        }

        public void print()
        {
            Console.WriteLine(this.toString());
        }

        public String toString()
        {
            return this.type + "\t" +
                    this.size + "\t" +
                    //this.tag + "\t" +
                    this.data + "\t" +
                    this.prevData;
        }
    }
}
