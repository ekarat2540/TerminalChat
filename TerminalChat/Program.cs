using System.Net.Sockets;

class Sender { 
    static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("Enter messagge here");
            TcpClient client = new TcpClient("192.168.1.100",5713);
            NetworkStream stream = client.GetStream();
            StreamWriter writer = new StreamWriter(stream);
            string message;
            while ((message = Console.ReadLine()) != "exit")
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
