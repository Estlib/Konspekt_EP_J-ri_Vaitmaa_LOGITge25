namespace ClassLibrary1
{
    public class Class1
    {
        public Class1(string messagestring)
        {
            MsgForUser = messagestring;
        }
        public string MsgForUser { get; set; } = "Helloäääää";
        public void WhatsTheWord()
        {
            Console.WriteLine(MsgForUser);
        }
    }
}
