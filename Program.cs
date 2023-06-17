namespace DepInj{
// See https://aka.ms/new-console-template for more information
    class Program
    {

        static void Main(string[] args){
            Notifecation notifecation = new Notifecation(new Hotmail());
            notifecation.SendMail();
        }
    }
}
