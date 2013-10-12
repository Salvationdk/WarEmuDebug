using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Reflection;
namespace WarhammerEmu.GameServer
{
    public class Listener
    {
        private string hostIp;
        private int hostPort;
        protected static Socket m_socket;

        public Listener(string hostIp, int hostPort)
        {
            this.hostIp = hostIp;
            this.hostPort = hostPort;
        }
        public void Run()
        {
            Log.Debug("GameServer: Listening for connections..");
            try
            {
                LoadCryptHandler();
                m_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                m_socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, true);
                m_socket.Bind(new IPEndPoint(IPAddress.Parse(hostIp), hostPort));
                m_socket.Listen(10);
                m_socket.BeginAccept(new AsyncCallback(OnConnect), null);
            }
            catch (SocketException se)
            {
                Log.Warn("GameServer: Listener exception.." + se);
            }
        }
        private void OnConnect(IAsyncResult asyn)
        {

            var socket = m_socket.EndAccept(asyn);
            Connection connection = new Connection(socket,this);
            m_socket.BeginAccept(new AsyncCallback(OnConnect), null);
        }

        public readonly Dictionary<string, ICryptHandler> m_cryptHandlers = new Dictionary<string, ICryptHandler>();
        public void LoadCryptHandler()
        {
           // Log.Info("TCPManager", "Loading Crypt Handler");

            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (Type type in assembly.GetTypes())
                {
                    // Pick up a class
                    if (type.IsClass != true)
                        continue;

                    CryptAttribute[] crypthandler =
                        (CryptAttribute[])type.GetCustomAttributes(typeof(CryptAttribute), true);

                    if (crypthandler.Length > 0)
                    {
                     //   Log.Debug("TCPManager", "Registering crypt " + crypthandler[0]._CryptName);
                        m_cryptHandlers.Add(crypthandler[0]._CryptName, (ICryptHandler)Activator.CreateInstance(type));
                    }
                }
            }
        }

        public ICryptHandler GetCrypt(string name)
        {
            if (m_cryptHandlers.ContainsKey(name))
                return m_cryptHandlers[name];
            else
                return null;
        }


        static public int GetTimeStamp()
        {
            return (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
        }
    }
}
