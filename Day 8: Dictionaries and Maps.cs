class Solution {
    
    static void Main(String[] args) {
        
        // first input is number of contacts
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        var inputContacts = new List<string>();
        var contactsToCheck = new List<string>();
        
        // get contacts from console
        while (n > 0)
        {
            inputContacts.Add(Console.ReadLine());
            n--;
        }        
           
        // get names to check from console   
        while (true)
        {
            var input = Console.ReadLine();
            
            if (input == null)
            {
                break;
            }
            
            contactsToCheck.Add(input);
        }
   
        
        // create phonebook
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
                
        foreach(var item in inputContacts)
        {
            string[] words = item.Split(' ');
            phoneBook.Add(words[0], words[1]);
        }
        
        // check contacts and output result
        foreach(var item in contactsToCheck)
        {
           if(phoneBook.ContainsKey(item))
           {
                Console.WriteLine(item + "=" + phoneBook[item]);
           } else 
           {
                Console.WriteLine("Not found");  
           }
        }
    }
}
