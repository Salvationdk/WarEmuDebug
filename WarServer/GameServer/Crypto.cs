using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;


namespace WarhammerEmu.GameServer
{
    public class Crypto
    {
        #region Crypto

        public static byte[] RC4Key;
        public static bool hasKey = false;
        public static bool AddCrypt(byte[] key)
        {
            RC4Key = new byte[256];
            Buffer.BlockCopy(key, 0, RC4Key, 0, 256);
            hasKey = true;
            return true;
        }

        public static PacketIn Decrypt(byte[] Key, byte[] packet)
        {
            PacketIn Packet = new PacketIn(packet, 0, packet.Length);
            Packet = Packet.DecryptMythicRC4(Key);

            return Packet;
        }

        public static PacketIn DeCrypt(PacketIn packet,byte[] key)
        {

            ulong opcode = packet.Opcode;
            ulong size = packet.Size;
            long StartPos = packet.Position;

                try
                {
                  //  Log.Debug("Decrypt", "Decrypt with " + Entry.Key + ",Size=" + packet.Size);

                    byte[] Buf = new byte[size];

                    long Pos = packet.Position;
                    packet.Read(Buf, 0, (int)Buf.Length);
                    packet.Position = Pos;


                    PacketIn dePacket = new PacketIn(Buf, 0, Buf.Length);
                    dePacket = dePacket.DecryptMythicRC4(key);

                  //  PacketIn Pack = Entry.Key.Decrypt(Entry.Value[1], Buf);
                    packet.Write(dePacket.ToArray(), 0, dePacket.ToArray().Length);

                    packet.Opcode = opcode;
                    packet.Size = size;
                }
                catch (Exception e)
                {
                    Log.Error("BaseClient", "Decrypt Error : " + e.ToString());
                    //continue;
                }
            

           // Log.Tcp("Decrypt", packet.ToArray(), 0, packet.ToArray().Length);
            packet.Position = StartPos;
            return packet;
        }

        public static PacketOut Crypt(PacketOut packet,byte[] key)
        {

            byte[] Packet = packet.ToArray();

          //  Log.Tcp("SendTCP", Packet, 0, (int)Packet.Length);

            int Hpos = 0;
            Hpos += PacketOut.SizeLen;
            if (PacketOut.OpcodeInLen)
                Hpos += packet.OpcodeLen;

            byte[] Header = new byte[Hpos];
            byte[] ToCrypt = new byte[(packet.Length - Hpos)];

            for (int i = 0; i < Hpos; ++i)
                Header[i] = Packet[i];

            for (int i = Hpos; i < Packet.Length; ++i)
                ToCrypt[i - Hpos] = Packet[i];

            try
            {


                ToCrypt = PacketOut.EncryptMythicRC4(key, ToCrypt);
                
            }
            catch (Exception e)
            {
                Log.Error("BaseClient", "Crypt Error : " + e.ToString());
                return packet;
            }

            PacketOut Out = new PacketOut((byte)0);
            Out.Opcode = packet.Opcode;
            Out.OpcodeLen = packet.OpcodeLen;
            Out.Position = 0;
            Out.SetLength(0);

            byte[] Total = new byte[Header.Length + ToCrypt.Length];

            for (int i = 0; i < Total.Length; ++i)
            {
                if (i < Header.Length)
                    Total[i] = Header[i];
                else
                    Total[i] = ToCrypt[i - Header.Length];
            }

            Out.Write(Total, 0, Total.Length);

            return Out;
        }

        #endregion

        public static T ByteToType<T>(PacketIn packet)
        {
            BinaryReader reader = new BinaryReader(packet);
            byte[] bytes = reader.ReadBytes(System.Runtime.InteropServices.Marshal.SizeOf(typeof(T)));

            GCHandle handle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
            T theStructure = (T)System.Runtime.InteropServices.Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();

            return theStructure;
        }

   
    }
}
