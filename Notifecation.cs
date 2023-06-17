namespace DepInj{
// See https://aka.ms/new-console-template for more information
    public class Notifecation{
        public IMessage _IMessage;
        public Notifecation(IMessage iMessage){
            this._IMessage = iMessage;
        }


        public void SendMail(){
            this._IMessage.Send();
        }
        
    }
}
