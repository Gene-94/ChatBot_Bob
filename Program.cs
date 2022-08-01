namespace moody_teen_chatbot;
class Program
{   
    
    static void Main(string[] args)
    {
        Bob bobChat = new Bob();
        string? name = "";
        string? message;
        Console.Write("\n\nHey! What's your name?\n{0}> ",name);
        name = Console.ReadLine();
        Console.WriteLine("Nice to meet you {0}.\nHere, meet Bob, he is our resident teen and loves to chat(*sarcasm*)", name);
        Console.WriteLine("\n### Conversation with Bob ###\n(type end or enough to quit the conversation)\n");
        Console.WriteLine("Bob > ...");
        do{
            Console.Write("{0} > ", name);
            message = Console.ReadLine();
            Console.WriteLine("Bob > {0}", bobChat.Response(message));
        }while(!String.IsNullOrWhiteSpace(message) && ( !message.Contains("exit") || !message.Contains("enough") || !message.Contains("Enough") || !message.Contains("end") || !message.Contains("End")));
        Console.WriteLine("\n### Conversation with Bob ended ###\n");
        Console.WriteLine("Yeahhh... So That was Bob...");
        Console.WriteLine("Well, se ya {0}!", name);
        
    }
}
