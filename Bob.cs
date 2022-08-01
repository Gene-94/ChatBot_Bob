using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace moody_teen_chatbot
{
    /*
    Bob is a lackadaisical teenager. In conversation, his responses are very limited.

    Bob answers 'Sure.' if you ask him a question, such as "How are you?".

    He answers 'Whoa, chill out!' if you YELL AT HIM (in all capitals).

    He answers 'Calm down, I know what I'm doing!' if you yell a question at him.

    He says 'Fine. Be that way!' if you address him without actually saying anything.

    He answers 'Whatever.' to anything else.

    Bob's conversational partner is a purist when it comes to written communication and always follows normal rules regarding sentence punctuation in English.


    */


    public class Bob
    {
        public static bool checkUpper(string sample_string){
        bool check = false;
        foreach(char x in sample_string)
            if(char.IsLetter(x)){
                if(!Char.IsUpper(x))
                    return false;
                check = true;
            }
        return check;
        }
    
        public string Response(string? statement)
        {   
            if(String.IsNullOrWhiteSpace(statement))
                return "Fine. Be that way!";
            else if(statement.Trim().EndsWith('?')&&checkUpper(statement))
                return "Calm down, I know what I'm doing!";
            else if(checkUpper(statement))
                return "Whoa, chill out!";
            else if(statement.Trim().EndsWith('?'))
                return "Sure.";
            else
                return "Whatever.";
        }
    }
}