using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using WebSocketSharp;


namespace sockets
{
    class Program  
    {

        private static async Task Echo()
        {
            try//commiting in dev jnanesh...
            {
                //using (ClientWebSocket ws = new ClientWebSocket()) //diff branch
                //{
                //    //Uri serverUri = new Uri("wss://clientapi.mickrex.com/api/balance/getbalance?sessionToken={sessionToken}");
                //    Uri serverUri = new Uri("ws://reqres.in/api/users");
                //    await ws.ConnectAsync(serverUri, CancellationToken.None);

                //    while (ws.State == System.Net.WebSockets.WebSocketState.Open)
                //    {
                //        Console.Write("Input message ('exit' to exit): ");
                //        string msg = Console.ReadLine();
                //        if (msg == "exit")
                //        {
                //            break;
                //        }
                //        ArraySegment<byte> bytesToSend = new ArraySegment<byte>(Encoding.UTF8.GetBytes(msg));
                //        await ws.SendAsync(bytesToSend, WebSocketMessageType.Text, true, CancellationToken.None);
                //        ArraySegment<byte> bytesReceived = new ArraySegment<byte>(new byte[1024]);
                //        WebSocketReceiveResult result = await ws.ReceiveAsync(bytesReceived, CancellationToken.None);
                //        Console.WriteLine(Encoding.UTF8.GetString(bytesReceived.Array, 0, result.Count));
                //    }
                //}
                //using (ClientWebSocket ws = new ClientWebSocket())
                //{
                //    //Uri serverUri = new Uri("wss://clientapi.mickrex.com/api/balance/getbalance?sessionToken={sessionToken}");
                //    Uri serverUri = new Uri("ws://reqres.in/api/users");
                //    await ws.ConnectAsync(serverUri, CancellationToken.None);

                //    while (ws.State == System.Net.WebSockets.WebSocketState.Open)
                //    {
                //        Console.Write("Input message ('exit' to exit): ");
                //        string msg = Console.ReadLine();
                //        if (msg == "exit")
                //        {
                //            break;
                //        }
                //        ArraySegment<byte> bytesToSend = new ArraySegment<byte>(Encoding.UTF8.GetBytes(msg));
                //        await ws.SendAsync(bytesToSend, WebSocketMessageType.Text, true, CancellationToken.None);
                //        ArraySegment<byte> bytesReceived = new ArraySegment<byte>(new byte[1024]);
                //        WebSocketReceiveResult result = await ws.ReceiveAsync(bytesReceived, CancellationToken.None);
                //        Console.WriteLine(Encoding.UTF8.GetString(bytesReceived.Array, 0, result.Count));
                //    }
                //}
                ClientWebSocket test = new ClientWebSocket();

                //string result = null;
                //string host = "wss://reqres.in/api/users";
                //string host = "ws://dragonsnest.far/Laputa";
                //string host = "ws:localhost:52177/api/orders/getpendingorders?sessionToken=sessionToken";
                //string host = "wss://clientapi.mickrex.com/api/balance/getbalance/?sessionToken=ABCD";
                string host = "wss://adminapi.mickrex.com/api/Balance/gettransactiondetails?sessionToken={sessionToken}";
                
                WebSocketSharp.WebSocket soc = new WebSocketSharp.WebSocket(host);

                //if(soc.ReadyState.Equals(1))
                //{

                //}

                //soc.ConnectAsync();
                //soc.OnOpen += (sender, e) =>
                //{
                //    soc.Send("abc");
                //};
                string res = null;
                
                using (soc)
                {
                    //soc.OnMessage += (sender, e) =>
                    //{
                    //    Console.WriteLine(" hi says " + e.Data);
                    //};
                    //soc.Connect();
                    
                    soc.ConnectAsync();
                    soc.OnMessage += (sender, e) =>
                    {
                        Console.WriteLine(" hi says " + e.Data);
                        //res = e.Data;
                        if(e.Type == Opcode.Text)
                        {
                            
                        }
                        soc.Send(e.Data);
                        
                    };
                    var a = res;
                    
                    
                    //soc.Connect();

                }
                //soc.Send("adcd");
                //var a = result;


                //WebSocketSharp.WebSocket soc = new WebSocketSharp.WebSocket(host);
                //soc.ConnectAsync();

                //ArraySegment<byte> bytesReceived = new ArraySegment<byte>(new byte[1024]);
                //WebSocketReceiveResult result = await soc.ReceiveAsync(bytesReceived, CancellationToken.None);
                //Console.WriteLine(Encoding.UTF8.GetString(bytesReceived.Array, 0, result.Count));
                //WebSocket ws = new WebSocket("ws://localhost:8080/spring-websocket-stomp-apollo/chat");
                // ws.Origin = "http://localhost:8080";
                //using (ws)
                //{
                //    ws.OnOpen += ws_OnOpen;
                //    ws.OnError += ws_OnError;
                //    ws.OnMessage += ws_OnMessage;
                //    //ws.OnMessage += (sender, e) =>
                //    // Console.WriteLine("Laputa says: " + e.Data);

                //    ws.Connect();
                //    //ws.Send("SUBSCRIBE id:sub-0 destination:/topic/mytopic\0");
                //    Console.ReadKey(true);
                //}



            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        private static void Soc_OnOpen(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void get()
        {
            string host = "ws://reqres.in/api/users";
            WebSocketSharp.WebSocket soc;
            soc = new WebSocketSharp.WebSocket(host);
            soc.ConnectAsync();
            soc.OnMessage += (sender, e) =>
            {
                var d = e.Data;
            };
        }
        static void Main(string[] args)
        {
            try
            {
                //Program pg = new Program();
                //pg.get();
                //Console.WriteLine(pg.get());
                Task t = Echo();
                t.Wait();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
