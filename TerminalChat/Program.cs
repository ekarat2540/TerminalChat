using System.Net.Sockets;

class Sender { 
    static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("Enter messagge here");
            TcpClient client = new TcpClient();
            NetworkStream stream = client.GetStream();
            StreamWriter writer = new StreamWriter(stream);
            string message = Console.ReadLine();
            while(message != null)
            {
                writer.WriteLine(message);
                writer.Flush();
            }
            
        }
        catch (Exception e)
        {
            Console.Write(e.Message);
        }
    }
}
