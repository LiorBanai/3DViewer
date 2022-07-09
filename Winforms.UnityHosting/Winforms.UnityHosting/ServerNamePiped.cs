using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winforms.UnityHosting
{
    public class ServerNamePiped
    {
        private NamedPipeServerStream namedPipeServerStream;
        private Task Listen { get; set; }
        public ServerNamePiped()
        {
            try
            {
                //Create Server Instance
                namedPipeServerStream = new NamedPipeServerStream("Unity_Obj_Viewer", PipeDirection.InOut, 1);
                //Wait for a Client to connect
                namedPipeServerStream.WaitForConnection();
                Listen = Task.Run(() =>
                {
                    StreamString serverStream = new StreamString(namedPipeServerStream);
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Close()
        {
            namedPipeServerStream.Close();

        }
    }
}
