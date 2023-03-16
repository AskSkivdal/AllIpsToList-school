using System;

namespace AllIps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<uint> ips = get_compacted_ips();
        }

        static List<uint> get_compacted_ips()
        {
            List<uint> ips = new List<uint>();

            for (byte ip1 = 0; ip1 <= 255; ip1++)
            {
                for (byte ip2 = 0; ip2 <= 255; ip2++)
                {
                    for (byte ip3 = 0; ip3 <= 255; ip3++)
                    {
                        for (byte ip4 = 0; ip4 <= 255; ip4++)
                        {
                            uint compact_ip = (uint)(ip1 ^ (ip2 << 8) ^ (ip3 << 16) ^ (ip4 << 24));
                            
                            ips.Add(compact_ip);
                        }
                    }
                }
            }

            return ips;
        }
    }
}